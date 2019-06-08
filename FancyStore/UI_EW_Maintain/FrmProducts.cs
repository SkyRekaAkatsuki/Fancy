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

            cbCategory.SelectedIndex = -1;  //預設沒有選值
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        Product prod = new Product();
        int currentIndex; //目前位置

        //動態產生products資料
        void ResetData()
        {
            dbContext = new FancyStoreEntities(); //為了能刷新資料

            var s = dbContext.Suppliers.OrderBy(x=>x.SupplierID).ToList();
            cbSupplierName.DataSource = s;

            var q = dbContext.Products.Select(x => x);

            int pID;
            if (int.TryParse(txtProductID.Text, out pID))
            {
                q = q.Where(x => x.ProductID == pID).Select(x => x);
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
            productBindingSource.DataSource = q.ToList();
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
            cbCategory.SelectedValue = _clsProd._CategorySID;  //查詢條件中的Category的ComboBox, 重新指向存檔資料的分類
            ResetData();
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
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return;
            }

            switch (e.ColumnIndex)
            {
                case 0:      //Click 修改
                    FrmProductMaintain f = new FrmProductMaintain("U", prod);
                    f.ShowDialog();
                    cbCategory.SelectedValue = _clsProd._CategorySID;  //查詢條件中的Category的ComboBox, 重新指向存檔資料的分類
                    ResetData();
                    break;

                case 1:      //Click 刪除
                    if (MessageBox.Show("確定要刪除嗎?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (HasProductDetails()) //有Details資料
                        {
                            MessageBox.Show($"ProductID:{prod.ProductID} ({prod.ProductName}) 有存在 [顏色 / 尺吋大小 / 庫存量 / 圖片 / 洗滌方式 / 產品評價] 等資料, 不能刪除 !");
                            return;
                        }
                        try
                        {
                            var n = dbContext.Products.Find(prod.ProductID);
                            dbContext.Products.Remove(n);
                            this.dbContext.SaveChanges();
                            { MessageBox.Show("產品 [刪除] 資料成功 !"); }
                            ResetData();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                            MessageBox.Show("產品 [刪除] 資料失敗, 請檢查欄位資料後再試一下, 或找系統管理員協助處理 !");
                        }
                    }
                    break;
            }

            //判斷Product是否有其他Details資料
            bool HasProductDetails()
            {
                if (dbContext.ProductEvaluations.Any(x => x.ProductID == prod.ProductID))  //有 ProductEvaluations
                { return true; }

                if (dbContext.ProductWashings.Any(x => x.ProductID == prod.ProductID))  //有 ProductWashings
                { return true; }

                if (dbContext.ProductPhotoes.Any(x => x.ProductID == prod.ProductID))  //有 ProductPhotoes
                { return true; }

                if (dbContext.ProductColors.Any(x => x.ProductID == prod.ProductID))  //有 ProductColor
                { return true; }

                if (dbContext.ProductSizes.Any(x => x.ProductID == prod.ProductID))  //有 ProductSize
                { return true; }

                if (dbContext.ProductStocks.Any(x => x.ProductID == prod.ProductID))  // 有ProductStock
                { return true; }

                return false;  //無任何Details資料
            }
        }
    }
}
