using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;

namespace UI_EW_Maintain
{
    public partial class FrmProductWashing : Form
    {
        public FrmProductWashing()
        {
            InitializeComponent();
        }
        public FrmProductWashing(Product prod)
        {
            InitializeComponent();

            cProd = prod;

            lblProductID.Text = cProd.ProductID.ToString();
            lblProductName.Text = cProd.ProductName;
            txtDesc.Text = cProd.Desctiption;
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        Product cProd = new Product();

        private void FrmWashing_Load(object sender, EventArgs e)
        {
            //將cbWashing給DataSource
            var q = dbContext.Washings.ToList();
            cbWashing.DataSource = q;
            WashingName.DataSource = q;
            cbWashing.SelectedIndex = -1;

            ResetData();
        }

        void ResetData()
        {
            dbContext = new FancyStoreEntities();

            var q = dbContext.ProductWashings.Where(x => x.ProductID == cProd.ProductID).Select(x => x);

            productWashingBindingSource.DataSource = q.ToList();
            productWashingDataGridView.DataSource = productWashingBindingSource;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cbWashing.SelectedIndex < 0)
            {
                MessageBox.Show($"尚未選取 [洗滌方式] , 無法存檔");
                return;
            }
            //判斷洗滌方式是否重覆
            int washingID = (int)cbWashing.SelectedValue;
            if (dbContext.ProductWashings.Any(x => x.ProductID == cProd.ProductID && x.WashingID == washingID))
            {
                MessageBox.Show($"產品的 [洗滌方式] 重覆 , 無法存檔");
                return;
            }

            try   //寫入ProductWashing
            {
                ProductWashing pw = new ProductWashing();

                pw.ProductID = cProd.ProductID;
                pw.WashingID = (int)cbWashing.SelectedValue;
                pw.CreateDate = DateTime.Now;

                dbContext.ProductWashings.Add(pw);
                dbContext.SaveChanges();

                int i = pw.ProductWashingID;  //取得資料庫自增ID
                MessageBox.Show($"洗滌方式 [新增] 資料成功 => ID: {i} ");
                ResetData();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show("洗滌方式 [新增] 資料失敗, 請檢查欄位資料後再試一下, 或找系統管理員協助處理 !");
            }
        }

        private void productWashingDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                // EntityFramework 使用Sql Command, 一次刪除多筆資料
                //dbContext.Database.ExecuteSqlCommand("delete aaa where aaa.id = @CategoryLID", new SqlParameter("@CategoryLI", cl.CategoryLID));


                case 1:      //Click 刪除
                    if (MessageBox.Show("確定要刪除嗎?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int prodWashingID = ((ProductWashing)productWashingBindingSource.Current).ProductWashingID;
                            var n = dbContext.ProductWashings.Find(prodWashingID);

                            dbContext.ProductWashings.Remove(n);
                            dbContext.SaveChanges();
                            { MessageBox.Show("洗滌方式 [刪除] 資料成功 !"); }
                            ResetData();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                            MessageBox.Show("洗滌方式 [刪除] 資料失敗, 請檢查欄位資料後再試一下, 或找系統管理員協助處理 !");
                        }
                    }
                    break;
            }
        }
    }
}
