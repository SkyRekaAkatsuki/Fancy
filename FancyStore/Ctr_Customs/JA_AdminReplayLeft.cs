using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ctr_Customs
{
    public partial class JA_AdminReplayLeft : UserControl
    {
        public event Action 點擊;
        public string _Pname { set { this.label1.Text = value; } }
        public string _Count { set { this.label1.Text += $"({value})"; } }
        public JA_AdminReplayLeft()
        {
            InitializeComponent();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(188, 171, 143);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Transparent;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(188, 171, 143);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if(點擊!=null)
            {
                點擊();
            }
        }
    }
}
