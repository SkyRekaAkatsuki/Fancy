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
    public partial class JA_OrderDetailList : UserControl
    {
        public string _pname { set { this.Pname.Text = value; } }
        public string _pcolor { set { this.Pcolor.Text = value; } }
        public string _size { set { this.Psize.Text = value; } }
        public string _up { set { this.up.Text = value; } }
        public string _qty { set { this.QTY.Text = value; } }
        public string _小計 { set { this.小計.Text = value; } }

        public JA_OrderDetailList()
        {
            InitializeComponent();
        }
    }
}
