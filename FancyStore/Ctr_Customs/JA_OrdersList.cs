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
        public DateTime? _Shipdate { get { return _Shipdate; } set { this.Shipdate.Text = value.Value.ToShortDateString(); } }
        public string _PayMethod { get { return _PayMethod; } set { this.PayMethod.Text = value; } }
        public string _Shipping { get { return _Shipping; } set { this.Shipping.Text = value; } }
        public string _Discount { get { return _Discount; } set { this.Discount.Text = value; } }
        public string _OrderStatus { get { return _OrderStatus; } set { this.OrderStatus.Text = value; } }
        public JA_OrdersList()
        {
            InitializeComponent();
            Action action = () =>
            {
                JA_OrderDetail orderDetail = new JA_OrderDetail();
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
