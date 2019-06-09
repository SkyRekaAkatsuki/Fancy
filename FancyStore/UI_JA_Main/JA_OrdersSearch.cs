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

            Loaddata(Cls_JA_Member.db.OrderHeaders.Where(n =>n.OrderDate.Year ==DateTime.Now.Year&&
                     n.OrderDate.Month == DateTime.Now.Month
            ).ToList());
        }


        Status mod = Status.All;
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
                this.flowLayoutPanel1.Controls.Add(ordersList);
                過濾();
                Application.DoEvents();
            }

        }
        void 過濾()
        {
            foreach (var item in this.flowLayoutPanel1.Controls)
            {
                if ((((JA_OrdersList)item)._Status & mod) == ((JA_OrdersList)item)._Status)
                {
                    ((JA_OrdersList)item).Visible = true;
                }
                else { ((JA_OrdersList)item).Visible = false; }
            }
        }
    }
}
