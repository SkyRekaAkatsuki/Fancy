using DB_Fancy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_Utility;
using System.Diagnostics;

namespace UI_EW_Maintain
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            //將cbCategory給DataSource
            var q = dbContext.VW_EW_CategorySML.ToList();
            cbCategory.DataSource = q;
            cbCategorySName.DataSource = q;
            var s = dbContext.Suppliers.ToList();
            cbSupplierName.DataSource = s;

            cbCategory.SelectedIndex = -1;  //預設沒有選值
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        Product prod = new Product();

        string whereStr;  //where條件式
        int currentIndex; //目前位置

        //動態產生products資料
        void ResetData()
        {
            var q = dbContext.Products.Select(x=> x);

            int pID;
            if (int.TryParse( txtProductID.Text ,out pID))
            {               
                q = q.Where(x => x.ProductID == pID).Select(x=>x);
            }
            else
            {
                txtProductID.Text = "";
            }
            if (txtProductName.Text != "")
            {
                q = from x in q
                    where x.ProductName.Contains(txtProductName.Text)
                    select x;
            }
            try
            {
                pID = (int)cbCategory.SelectedValue;
                q = q.Where(x => x.CategorySID == pID).Select(x => x);
            }
            catch (NullReferenceException ex)
            {
                Debug.WriteLine(ex);
            }
            productBindingSource.DataSource =q.ToList();
            productDataGridView.DataSource = productBindingSource;
        }

        private void tsbClearSearch_Click(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = -1;
            txtProductID.Text = "";
            txtProductName.Text = "";
            ResetData();
        }
        //查詢
        private void btnFind_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        //新增
        private void btnInsert_Click(object sender, EventArgs e)
        {
            prod.ProductID = 0;
            if (this.cbCategory.SelectedIndex >= 0)
            {
                prod.CategorySID = int.Parse(this.cbCategory.SelectedValue.ToString());
            }
            FrmProductMaintain f = new FrmProductMaintain("C", prod);
            f.ShowDialog();
        }

        //移動指標
        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            currentIndex = productBindingSource.Position;
            try
            {
                prod.ProductID = ((Product)productBindingSource.Current).ProductID;
                prod.ProductName = ((Product)productBindingSource.Current).ProductName;
                prod.Desctiption = ((Product)productBindingSource.Current).Desctiption;
                prod.CategorySID = ((Product)productBindingSource.Current).CategorySID;
                prod.UnitPrice = ((Product)productBindingSource.Current).UnitPrice;
                prod.ProductInDate = ((Product)productBindingSource.Current).ProductInDate;
                prod.ProductOutDate = ((Product)productBindingSource.Current).ProductOutDate;
                prod.SupplierID = ((Product)productBindingSource.Current).SupplierID;
                prod.CreateDate = ((Product)productBindingSource.Current).CreateDate;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
