using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;
using Cls_Utility;
using System.Diagnostics;

namespace UI_EW_Maintain
{
    public partial class FrmInOut : Form
    {
        public FrmInOut()
        {
            InitializeComponent();

            // 注意1: 下面這句只能在第一次執行時使用, 會把上面自行創建的 ProcessBar控制項加作DataGridView
            // 注意2: 加入之前, DataGridView必須是看己手動從工具箱拉進來的, 不能有任何資料繫結, 否則不允許加入
            // 注意3: 若第一次執行已加入ProcessBar控制項後, 若不註解掉, 會出現Error, 不允許執行

            //CalendarColumn col = new CalendarColumn();
            //productDataGridView.Rows.Add(col);
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        Product prodStock = new Product();


        private void FrmInOut_Load(object sender, EventArgs e)
        {
            int yy = DateTime.Now.Year;
            int mm = DateTime.Now.Month;

            this.dateTimePicker1.Text = $"{yy}/{mm}/{1}";
            this.dateTimePicker2.Text = $"{yy}/{mm}/{DateTime.DaysInMonth(yy, mm)}";


            var c = dbContext.VW_EW_CategorySML;
            vWEWCategorySMLBindingSource.DataSource = c.ToList();
            cbCategory.SelectedIndex = -1;

            ResetData();
        }

        //動態產生products資料
        void ResetData()
        {
            dbContext = new FancyStoreEntities(); //為了能刷新資料

            var c = dbContext.VW_EW_CategorySML;
            vWEWCategorySMLBindingSource1.DataSource = c.ToList();  //DataGridView中的Category

            var s = dbContext.Suppliers;
            SupplierName.DataSource = s.ToList();

            DateTime date_b = DateTime.Parse(dateTimePicker1.Text).Date;
            DateTime date_t = DateTime.Parse(dateTimePicker2.Text).Date;

            var q = from x in dbContext.Products.AsEnumerable()
                    where ((x.ProductInDate >= date_b) && (x.ProductInDate <= date_t.AddDays(1)))
                    || ((x.ProductOutDate >= date_b) && (x.ProductOutDate <= date_t.AddDays(1)))
                    select x;
;

            if (txtProductName.Text != "")
            {
                q = from x in q
                    where x.ProductName.Contains(txtProductName.Text)
                    select x;
            }

            int cID;
            try
            {
                cID = (int)cbCategory.SelectedValue;
                q = q.Where(x => x.CategorySID == cID).Select(x => x);
            }
            catch (NullReferenceException ex)
            {
                Debug.WriteLine(ex);
            }

            productBindingSource.DataSource = q.ToList();
            productDataGridView.DataSource = productBindingSource;
        }

        //查詢
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(dateTimePicker1.Text) > DateTime.Parse(dateTimePicker2.Text))
            {
                MessageBox.Show("[下架日期] 不可小於 [上架日期] !");
                dateTimePicker2.Text = dateTimePicker1.Text;
                dateTimePicker2.Focus();
            }
            else
            { ResetData(); }
        }


        //清空查詢條件
        private void tsbCearSearch_Click(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = -1;
            txtProductName.Text = "";
            ResetData();
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Product pd = new Product();

            switch (e.ColumnIndex)
            {
                case 1:  //存檔
                    try
                    {
                        pd.ProductID = ((Product)productBindingSource.Current).ProductID;

                        var q = dbContext.Products.Find(pd.ProductID);

                        q.ProductInDate = ((Product)productBindingSource.Current).ProductInDate;
                        q.ProductOutDate = ((Product)productBindingSource.Current).ProductOutDate;

                        this.dbContext.SaveChanges();

                        ResetData();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    break;
            }
        }
    }
}
