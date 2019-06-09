using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_Utility;

namespace Ctr_Customs
{
    public partial class JA_OrdersList : UserControl
    {

        public string _OrderNum { get { return _OrderNum; } set { this.OrderNum.Text = value; } }
        DateTime od;
        public DateTime _Orderdate { get { return od; } set { this.Orderdate.Text = value.ToString("yyyy/MM/dd"); od = value; } }
        public DateTime? _Shipdate { get { return _Shipdate; }
            set {
                this.Shipdate.Text = value.HasValue? value.Value.ToShortDateString(): DateTime.Now.ToString("yyyy/MM/dd");
            }
        }
        public string _PayMethod { get { return _PayMethod; } set { this.PayMethod.Text = value; } }
        public string _Shipping { get { return _Shipping; } set { this.Shipping.Text = value; } }
        public string _Freight { set { this.Freight.Text = value; } }
        public string _Discount {set { this.Discount.Text = value; } }
        public Status _Status;
        private string OStatus;
        public string _OrderStatus { get { return OStatus; }
            set {
                if (value == "開立") { this.OrderStatus.BackColor = Color.FromArgb(0, 179, 45); _Status = Status.開立; }
                else if (value == "出貨") { this.OrderStatus.BackColor = Color.FromArgb(255, 170, 51); _Status = Status.出貨; }
                else if(value == "取消") { this.OrderStatus.BackColor = Color.FromArgb(244, 67, 54); _Status = Status.取消; }
                OStatus = value;
                
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
                orderDetail.Name = this.Name;
                orderDetail.ShowDialog();
            };
            this.ssss.Click += (s, ee) => { action(); };
            this.ssss.MouseEnter += (s, ee) =>
            {
                this.BackColor = Color.FromArgb(224, 224, 224);
            };
            this.ssss.MouseLeave += (s, ee) =>
            {
                this.BackColor = Color.Transparent;
            };
            foreach (Control item in this.ssss.Controls)
            {
                item.MouseEnter += (s, ee) => 
                {
                    this.BackColor = Color.FromArgb(224, 224, 224);
                };
                item.MouseLeave += (s, ee) =>
                {
                    this.BackColor = Color.Transparent;
                };
                if (!(item is Button))
                {
                    item.Click += (s, ee) =>
                    {
                        action();
                    };
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_OrderStatus=="開立")
            {
                if (MessageBox.Show("你確定要取消訂單嗎", "提醒你", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (Cls_JA_Member.CancelOrder((Int32)this.Tag))
                    {
                        this.OrderStatus.Text = "取消";
                        this.OrderStatus.BackColor = Color.FromArgb(244, 67, 54);
                        _Status = Status.取消;
                        MessageBox.Show("取消成功");
                    }
                    else
                    {
                        MessageBox.Show("取消出現問題，可能無法取消。");
                    }
                }
            }
            else
            {
                MessageBox.Show("此訂單已無法取消。");
            }

        }
    }
}
