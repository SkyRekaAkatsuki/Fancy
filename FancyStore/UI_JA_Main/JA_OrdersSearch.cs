using Cls_Utility;
using Ctr_Customs;
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

namespace UI_JA_Main
{
    public partial class JA_OrdersSearch : Form
    {


        public JA_OrdersSearch()
        {
            InitializeComponent();
            FancyStoreEntities db = new FancyStoreEntities();
            Loaddata(db.OrderHeaders.Where(n =>n.OrderDate.Year ==DateTime.Now.Year&&
                     n.OrderDate.Month == DateTime.Now.Month
            ).OrderByDescending(n=>n.OrderDate).ToList());
        }


        Status mod = Status.All;
        int count;
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            { mod = mod | ((Status)int.Parse(((CheckBox)sender).Tag.ToString())); }
            else
            { mod = mod ^ ((Status)int.Parse(((CheckBox)sender).Tag.ToString())); }

            過濾();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Loaddata(Cls_JA_Member.db.OrderHeaders.Where(n => n.OrderDate >= this.dateTimePicker1.Value &&
                    n.OrderDate <= this.dateTimePicker2.Value
                    ).ToList());
        }

        private void Loaddata(List<OrderHeader> data)
        {
            this.flowLayoutPanel1.Controls.Clear();
           
            foreach (var item in data.Where(n=>n.UserID==Cls_JA_Member.UserID))
            {
                JA_OrdersList ordersList = new JA_OrdersList
                {
                    _OrderNum = item.OrderNum,
                    _Orderdate = item.OrderDate,
                    _Shipdate = item.ShipDate,
                    _PayMethod = item.PayMethod.PayMethodName,
                    _Shipping = item.Shipping.ShippingName,
                    _Freight = item.PayMethod.Freight.ToString(),
                    _Discount = item.DiscountMethod.DiscountName,
                    _OrderStatus = item.OrderStatusList.OrderStatusName,
                    _Amount = item.OrderAmount.ToString(),
                    Tag = item.OrderID,
                    Name = item.OrderNum
                };
                ordersList.detailclose += delegate
                {
                   // this.flowLayoutPanel1.AutoScrollPosition = new Point( Math.Abs(p.X),0);
                };
                this.flowLayoutPanel1.Controls.Add(ordersList);
                Application.DoEvents();
            }
            過濾();
        }
        void 過濾()
        {
            count = 0;
            foreach (JA_OrdersList item in this.flowLayoutPanel1.Controls)
            {
                if ((item._Status & mod) == item._Status)
                {
                    item.Visible = true;
                    count++;
                }
                else { item.Visible = false; }
            }
            label2.Text = count.ToString();
        }
        Point p;
        private void JA_OrdersSearch_MouseMove(object sender, MouseEventArgs e)
        {
            p = flowLayoutPanel1.AutoScrollPosition;
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }
    }
}
