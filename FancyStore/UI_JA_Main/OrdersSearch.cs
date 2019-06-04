using Cls_Utility;
using Ctr_Customs;
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
    public partial class OrdersSearch : Form
    {
        public OrdersSearch()
        {
            InitializeComponent();

            for(int i =0;i<10;i++)
            //foreach (var item in Cls_JA_Member.db.OrderHeaders)
            {
                JA_OrdersList ordersList = new JA_OrdersList
                {
                    //_OrderNum = item.OrderNum,
                    //_Orderdate = item.OrderDate,
                    //_Shipdate = item.ShipDate,
                    //_PayMethod =item.PayMethod.PayMethodName,
                    //_Shipping = item.Shipping.ShippingName,
                    //_Discount = item.DiscountMethod.DiscountName,
                    //_OrderStatus = item.OrderStatusList.OrderStatusName,
                    //Tag = item.OrderID
                };
                this.flowLayoutPanel1.Controls.Add(ordersList);
                Application.DoEvents();
            }



        }
    }
}
