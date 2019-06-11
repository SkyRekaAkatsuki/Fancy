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
    public partial class AL_NewsInfo : UserControl
    {
        public AL_NewsInfo()
        {
            InitializeComponent();
            origin = BackColor;
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                c.MouseEnter += C_MouseEnter;
                c.MouseLeave += C_MouseLeave;
            }
        }

        private void C_MouseLeave(object sender, EventArgs e)
        {
            BackColor = origin;
        }

        private void C_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        Color origin;
        public int NewsID { set { label1.Text = value.ToString(); } }
        public string Title { set { label2.Text = value; } }
        public DateTime NewsDate { set { label3.Text = value.ToString(); } }
        public string NewsContent { set { label4.Text = value; } }
        public int PhotoID { set { label5.Text = value.ToString(); } }
    }
}
