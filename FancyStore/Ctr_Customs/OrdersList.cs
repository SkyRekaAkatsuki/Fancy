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
    public partial class OrdersList : UserControl
    {

        public string _OrderNum { get; set; }
        public DateTime _Orderdate { get; set; }
        public DateTime? _Shipdate { get; set; }
        public string _PayMethod { get; set; }
        public string _Shipping { get; set; }
        public string _Discount { get; set; }
        public string _OrderStatus { get; set; }
        public string _OrderAmount { get; set; }
        public OrdersList()
        {
            InitializeComponent();

        }
    }
}
