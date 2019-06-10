using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;
using Cls_Utility;

namespace Ctr_Customs
{
    public partial class EW_Cart : UserControl
    {
        public EW_Cart()
        {
            InitializeComponent();
        }
        FancyStoreEntities dbContext = new FancyStoreEntities();

        CartItem ct = new CartItem();
        int index;


        public EW_Cart(int idx, CartItem cart)
        {
            InitializeComponent();
            ct = cart;
            index = idx;
        }

        private void EW_Cart_Load(object sender, EventArgs e)
        {
            lblProductName.Text = ct.ProductName;
            lblColor.Text = ct.ProductColorName;
            lblSize.Text = ct.ProductSizeName;
            lblUnitPrice.Text = ct.UnitPrice.ToString();
            nuQty.Value = ct.Qty;
            lblSubAmount.Text = (ct.UnitPrice * ct.Qty).ToString();

            var ps = dbContext.ProductStocks.Where(x => x.ProductID == ct.ProductID
            && x.ProductSizeID == ct.ProductSizeID && x.ProductColorID == ct.ProductColorID).FirstOrDefault();
            nuQty.Maximum = ps.StockQTY;
            lblStockQTY.Text = ps.StockQTY.ToString();
        }

        //會員修改數量
        private void nuQty_ValueChanged(object sender, EventArgs e)
        {
            Cls_Utility.Class1.CartList[index].Qty = (int)nuQty.Value;

            lblSubAmount.Text = (ct.UnitPrice * (int)nuQty.Value).ToString();
        }
        
        //取消產品訂購
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cls_Utility.Class1.CartList[index].Qty = 0;
            this.Height = 0;
        }
    }
}
