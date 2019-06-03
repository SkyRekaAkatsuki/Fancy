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
            cbCategory.DisplayMember = "CatetorySName";
            cbCategory.ValueMember = "CategorySID";

            cbCategory.DataSource = dbContext.CategorySmalls.AsEnumerable()
                .Select(x =>
                new
                {
                    CatetorySName = $"{x.CategoryMiddle.CategoryLarge.CategoryLName}" +
                                               $"-{x.CategoryMiddle.CategoryMName}" +
                                               $"-{x.CategorySName}",
                    x.CategorySID,
                }).ToList();

            cbCategory.SelectedIndex = -1;  //預設沒有選值
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        Product prod = new Product();

        string whereStr;  //where條件式
        int currentIndex; //目前位置

        //動態產生products資料
        void ResetData()
        {
            //where 條件字串的判斷
            whereStr = "1 = 1";

            if (txtProductID.Text != "")
            {
                whereStr += $" and ProductID = {txtProductID.Text}";
            }

            if (txtProductName.Text != "")
            {
                whereStr += $" and ProductName like '%{txtProductName.Text}%'";
            }

            try
            {
                whereStr += $" and CategorySID = '{(int)cbCategory.SelectedValue}'";
            }
            catch (NullReferenceException ex)
            {
                Debug.WriteLine(ex);
            }
            productBindingSource.DataSource = dbContext.Products.ToList();
            productBindingSource.Filter = whereStr;
            productDataGridView.DataSource = productBindingSource;
        }

        private void tsbClearSearch_Click(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = -1;
            txtProductID.Text = "";
            txtProductName.Text = "";
            ResetData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            currentIndex = productBindingSource.Position;

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
    }
}
