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

            ResetData();
        }

        void ResetData()
        {
            for (int i=0;i<= Cls_Utility.Class1.CartList.Count-1;i++)
            {
                EW_Cart ec = new EW_Cart(i,Cls_Utility.Class1.CartList[i]);

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
            IsPay = !IsPay;

            if(IsPay)
            {
                panel1.Height = 120;
                this.Height = 460;
                btnPay.Text = "取消結帳";
            }
            else
            {
                panel1.Height = 0;
                this.Height = 330;
                btnPay.Text = "結帳";
            }            
        }

        //繼續購物
        private void btnExit_Click(object sender, EventArgs e)
        {
            //離開時刪除 QTY 為 0 的資料
            for (int i= Cls_Utility.Class1.CartList.Count() - 1; i >= 0; i--)
            {
                if (Cls_Utility.Class1.CartList[i].Qty ==0)
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
        }
    }
}
