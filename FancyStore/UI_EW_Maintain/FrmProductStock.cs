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
    public partial class FrmProductStock : Form
    {
        public FrmProductStock()
        {
            InitializeComponent();
        }
        public FrmProductStock(Product prod)
        {
            InitializeComponent();

            cProd = prod;

            lblProductID.Text = cProd.ProductID.ToString();
            lblProductName.Text = cProd.ProductName;
            txtDesc.Text = cProd.Desctiption;
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        Product cProd = new Product();

        private void FrmProductStock_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        void ResetData()
        {
            dbContext = new FancyStoreEntities();

            var s = dbContext.VW_EW_ProductSize;
            ProductSizeName.DataSource = s.ToList();

            var c = dbContext.VW_EW_ProductColor;
            ProductColorName.DataSource = c.ToList();

            var q = dbContext.ProductStocks.Where(x => x.ProductID == cProd.ProductID).Select(x => x);

            productStockBindingSource.DataSource = q.ToList();
            productStockDataGridView.DataSource = productStockBindingSource;
        }

        private void productStockDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:  //存檔
                    try
                    {
                        var q = dbContext.ProductStocks.Find(((ProductStock)productStockBindingSource.Current).StockID);
                        q.StockQTY = ((ProductStock)productStockBindingSource.Current).StockQTY;
                        q.MinStock = ((ProductStock)productStockBindingSource.Current).MinStock;
                        this.dbContext.SaveChanges();

                        MessageBox.Show($"產品庫存  [修改] 資料成功 !");

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
