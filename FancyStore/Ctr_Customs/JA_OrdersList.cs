using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ctr_Customs
{
    public partial class JA_OrdersList : UserControl
    {

        public string _OrderNum { get { return _OrderNum; } set { this.OrderNum.Text = value; } }
        public DateTime _Orderdate { get { return _Orderdate; } set { this.Orderdate.Text = value.ToString("yyyy/MM/dd"); } }
        public DateTime? _Shipdate { get { return _Shipdate; }
            set {
                if (value.HasValue) { this.Shipdate.Text = value.Value.ToShortDateString(); }
                else { this.Shipdate.Text = DateTime.Now.ToString("yyyy/MM/dd"); }
            }
        }
        public string _PayMethod { get { return _PayMethod; } set { this.PayMethod.Text = value; } }
        public string _Shipping { get { return _Shipping; } set { this.Shipping.Text = value; } }
        public string _Discount { get { return _Discount; } set { this.Discount.Text = value; } }
        public string _OrderStatus { get { return _OrderStatus; }
            set {
                if (value == "開立") { this.OrderStatus.BackColor = Color.FromArgb(0, 179, 45); }
                else if (value == "出貨") { this.OrderStatus.BackColor = Color.FromArgb(255, 170, 51); }
                else if(value == "取消") { this.OrderStatus.BackColor = Color.FromArgb(244, 67, 54); }
                this.OrderStatus.Text = value;
            }
        }

        public string _Amount { get { return _Amount; } set { this.Amount.Text = value; } }
        public JA_OrdersList()
        {
            InitializeComponent();
        }

        private void JA_OrdersList_Load(object sender, EventArgs e)
        {
            Action action = () =>
            {
                JA_OrderDetail orderDetail = new JA_OrderDetail();
                orderDetail.OrderID = (Int32)this.Tag;
                orderDetail.ShowDialog();
            };
            this.ssss.Click += (s, ee) => { action(); };
            foreach (Control item in this.ssss.Controls)
            {
                item.Click += (s, ee) =>
                {
                    action();
                };
            }
        }
    }
}
