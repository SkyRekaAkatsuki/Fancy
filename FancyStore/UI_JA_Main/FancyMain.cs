using Cls_Utility;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Timer = System.Windows.Forms.Timer;

namespace UI_JA_Main
{
    public partial class FancyMain : Form
    {
        List<Color> colors = new List<Color>();
        int currentColor = 0;
        int a = 0;
        public FancyMain()
        {

            Thread t = new Thread(new ThreadStart(delegate
           {
               Application.Run(new Loading());

           }));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            MessageBox.Show(Cls_JA_Member.UserID);
            colors.Add(Color.FromArgb(3, 169, 244));
            colors.Add(Color.FromArgb(33, 150, 243));
            colors.Add(Color.FromArgb(0, 150, 136));
            colors.Add(Color.FromArgb(103, 58, 183));
            colors.Add(Color.FromArgb(156, 39, 176));
            colors.Add(Color.FromArgb(255, 87, 34));
            colors.Add(Color.FromArgb(255, 193, 7));
            colors.Add(Color.FromArgb(205, 220, 57));
            t.Abort();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (currentColor < colors.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a, colors[currentColor], colors[currentColor + 1]);

                if (a < 100)
                {
                    a++;
                }
                else
                {
                    a = 0;
                    currentColor++;
                }
                timer1.Enabled = true;
            }
        }

        private void FancyMain_Load(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        bool userCheck = true;
        private void button1_Click(object sender, EventArgs e)
        {
            userCheck = !userCheck;
            Timer tim = new Timer();
            tim.Interval = 10;
            tim.Start();
            tim.Tick += delegate
            {
                if (userCheck)
                {
                    if (this.panel1.Width != 200) { this.panel1.Width += 10; }
                    else { tim.Stop(); tim.Dispose(); }
                }
                else
                {
                    if (this.panel1.Width != 0) { this.panel1.Width -= 10; }
                    else { tim.Stop(); tim.Dispose(); }
                }
            };
        }
        bool IfMdown = false;
        int NowX, NowY;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (IfMdown)
            {
                this.Location = new Point(this.Left += e.X - NowX, this.Top += e.Y - NowY);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            IfMdown = true;
            NowX = e.X;
            NowY = e.Y;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            IfMdown = false;
        }
    }
}

