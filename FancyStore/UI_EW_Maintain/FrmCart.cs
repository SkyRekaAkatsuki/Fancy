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
using Ctr_Customs;
using System.Diagnostics;

namespace UI_EW_Maintain
{
    public partial class FrmCart : Form
    {
        public FrmCart()
        {
            InitializeComponent();

            panel1.Height = 0;
            this.Height = 330;
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();

        private void FrmCart_Load(object sender, EventArgs e)
        {
            var pm = dbContext.PayMethods;
            payMethodBindingSource.DataSource = pm.ToList();
            comboBox1.DataSource = payMethodBindingSource;
            comboBox1.SelectedIndex = 0;

            ResetData();
        }

        //刷新購物車資料
        void ResetData()
        {
            for (int i = 0; i <= Cls_Utility.Class1.CartList.Count - 1; i++)
            {
                EW_Cart ec = new EW_Cart(i, Cls_Utility.Class1.CartList[i]);

                if (Cls_Utility.Class1.CartList[i].Qty > 0)
                {
                    flowLayoutPanel1.Controls.Add(ec);
                }
            }
        }

        bool IsPay = false;

        //結帳
        private void btnPay_Click(object sender, EventArgs e)
        {
            Caculate_Amount();

            if (EW_Library._OrderAmt == 0)
            {
                MessageBox.Show("購物車已無商品, 無法結帳, 請前往購物, 謝謝!");
                return;
            }

            IsPay = !IsPay;

            if (IsPay)
            {
                panel1.Height = 120;
                this.Height = 460;
                btnPay.Text = "取消結帳";
                flowLayoutPanel1.Enabled = false;
            }
            else
            {
                panel1.Height = 0;
                this.Height = 330;
                btnPay.Text = "結帳";
                flowLayoutPanel1.Enabled = true;
            }
        }

        //離開購物車
        private void btnExit_Click(object sender, EventArgs e)
        {
            //離開時刪除 QTY 為 0 的資料
            for (int i = Cls_Utility.Class1.CartList.Count() - 1; i >= 0; i--)
            {
                if (Cls_Utility.Class1.CartList[i].Qty == 0)
                {
                    Cls_Utility.Class1.CartList.RemoveAt(i);
                }
            }

            this.Dispose();
            this.Close();
        }

        //確認下單
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OrderHeader oh = new OrderHeader();
            oh.OrderNum = $"GD{DateTime.Now:yyyyMMddHHmmss}{ Cls_JA_Member.UserID.ToString()}";
            oh.OrderDate = DateTime.Now;
            oh.UserID = Cls_JA_Member.UserID;

            int pID = -1;
            try
            {
                pID = (int)comboBox1.SelectedValue;
            }
            catch (Exception ex)
            {
                pID = 1;
            }

            //OrderHeader 建檔
            oh.PayMethodID = pID;
            oh.ShippingID = 1;
            oh.DiscountID = 1;
            oh.OrderStatusID = 1;
            oh.OrderAmount = EW_Library._TotalAmt;
            oh.CreateDate = oh.OrderDate;

            try
            {
                dbContext.OrderHeaders.Add(oh);
                dbContext.SaveChanges();
                MessageBox.Show($"訂單 {oh.OrderNum} 建立成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"訂單建檔失敗 !");
                return;
            }

            //OrderDetail 建檔
            if (oh.OrderID > 0)
            {
                foreach (CartItem x in Cls_Utility.Class1.CartList)
                {
                    OrderDetail od = new OrderDetail();
                    od.OrderID = oh.OrderID;
                    od.ProductID = x.ProductID;
                    od.ProductColorID = x.ProductColorID;
                    od.ProductSizeID = x.ProductSizeID;
                    od.UnitPrice = (int)x.UnitPrice;
                    od.OrderQTY = x.Qty;
                    od.CreateDate = oh.CreateDate;

                    try
                    {
                        dbContext.OrderDetails.Add(od);
                        dbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"訂單明細建檔失敗 !");
                        return;
                    }
                }

            }

            //離開時清空List 的資料
            Cls_Utility.Class1.CartList.Clear();

            this.Dispose();
            this.Close();
        }


        //計算應付金額
        void Caculate_Amount()
        {
            int pmID = -1;
            try
            {
                pmID = (int)comboBox1.SelectedValue;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return;
            }

            var pm = dbContext.PayMethods.Where(x => x.PayMethodID == pmID).FirstOrDefault();

            EW_Library._Freight = (int)pm.Freight;

            EW_Library._OrderAmt = 0;
            for (int i = 0; i <= Cls_Utility.Class1.CartList.Count - 1; i++)
            {
                EW_Library._OrderAmt += (int)(Cls_Utility.Class1.CartList[i].UnitPrice * Cls_Utility.Class1.CartList[i].Qty);
            }

            EW_Library._TotalAmt = EW_Library._OrderAmt + EW_Library._Freight;

            lblFreight.Text = $"{EW_Library._Freight}";
            lblOrderAmt.Text = $"{EW_Library._OrderAmt}";
            lblTotalAmt.Text = $"{EW_Library._TotalAmt}";
        }

        //付款條件改變時, 要重新計算應付金額
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Caculate_Amount();
        }
    }
}
