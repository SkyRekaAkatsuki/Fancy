using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_JA_Main;

namespace UI_JA_Members
{
    public partial class Form2 : Form
    {
        Form1 go;
        public Form2()
        {
            InitializeComponent();
            go = new Form1();
            go.Width = this.Width;
            go.Height = this.Height;
            go.Show();
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IfMdown = false;
        }

        bool IfMdown = false;
        int NowX, NowY;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IfMdown)
            {
                this.Location = new Point(this.Left += e.X - NowX, this.Top += e.Y - NowY);
                go.Left = this.Left;
                go.Top = this.Top;
                
            }
            this.TopLevel = true;
            go.TopLevel = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IfMdown = true;
            NowX = e.X;
            NowY = e.Y;
        }

    }
}
