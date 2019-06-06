using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ctr_Customs
{
    public partial class JA_OrderDetail : Form
    {
        public int OrderID { get; set; }
        public JA_OrderDetail()
        {
            InitializeComponent();
            
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                OrderDetailList orderDetailList = new OrderDetailList
                {

                };
                this.flowLayoutPanel1.Controls.Add(orderDetailList);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
