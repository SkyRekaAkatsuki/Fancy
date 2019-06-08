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
    public partial class FrmProductSize : Form
    {
        public FrmProductSize()
        {
            InitializeComponent();
        }

        public FrmProductSize(Product prod)
        {
            InitializeComponent();

            cProd = prod;

            lblProductID.Text = cProd.ProductID.ToString();
            lblProductName.Text = cProd.ProductName;
            txtDesc.Text = cProd.Desctiption;
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        Product cProd = new Product();

        private void FrmProductSize_Load(object sender, EventArgs e)
        {
            //將cbSize給DataSource
            var q = dbContext.Sizes.ToList();
            cbSize.DataSource = q;
            SizeName.DataSource = q;
            cbSize.SelectedIndex = -1;

            ResetData();
        }

        void ResetData()
        {
            dbContext = new FancyStoreEntities();

            var q = dbContext.ProductSizes.Where(x => x.ProductID == cProd.ProductID).Select(x => x);

            productSizeBindingSource.DataSource = q.ToList();
            productSizeDataGridView.DataSource = productSizeBindingSource;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cbSize.SelectedIndex < 0)
            {
                MessageBox.Show($"尚未選取 [尺吋大小] , 無法存檔");
                return;
            }
            //判斷尺吋大小是否重覆
            int sizeID = (int)cbSize.SelectedValue;
            if (dbContext.ProductSizes.Any(x => x.ProductID == cProd.ProductID && x.SizeID == sizeID))
            {
                MessageBox.Show($"產品的 [尺吋大小] 重覆 , 無法存檔");
                return;
            }

            try   //寫入 ProductSize
            {
                ProductSize ps = new ProductSize();

                ps.ProductID = cProd.ProductID;
                ps.SizeID = (int)cbSize.SelectedValue;
                ps.CreateDate = DateTime.Now;

                dbContext.ProductSizes.Add(ps);
                dbContext.SaveChanges();

                int i = ps.SizeID;  //取得資料庫自增ID
                MessageBox.Show($"尺吋大小 [新增] 資料成功 => ID: {i} ");
                ResetData();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show("尺吋大小 [新增] 資料失敗, 請檢查欄位資料後再試一下, 或找系統管理員協助處理 !");
            }
        }

        private void productSizeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                // EntityFramework 使用Sql Command, 一次刪除多筆資料
                //dbContext.Database.ExecuteSqlCommand("delete aaa where aaa.id = @CategoryLID", new SqlParameter("@CategoryLI", cl.CategoryLID));


                case 1:      //Click 刪除
                    if (MessageBox.Show("確定要刪除嗎?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (HasProductDetails()) //有Details資料
                        {
                            MessageBox.Show($"ProductID:{cProd.ProductID} ({cProd.ProductName}) 有存在 [庫存量] 資料, 不能刪除 !");
                            return;
                        }
                        try
                        {
                            int prodSizeID = ((ProductSize)productSizeBindingSource.Current).ProductSizeID;
                            var n = dbContext.ProductSizes.Find(prodSizeID);

                            dbContext.ProductSizes.Remove(n);
                            dbContext.SaveChanges();
                            { MessageBox.Show("尺吋大小 [刪除] 資料成功 !"); }
                            ResetData();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                            MessageBox.Show("尺吋大小 [刪除] 資料失敗, 請檢查欄位資料後再試一下, 或找系統管理員協助處理 !");
                        }
                    }
                    break;
            }

            //判斷Product是否有其他Details資料
            bool HasProductDetails()
            {
                if (dbContext.ProductStocks.Any(x => x.ProductID == cProd.ProductID))  // 有ProductStock
                { return true; }

                return false;  //無任何Details資料
            }
        }
    }
}
