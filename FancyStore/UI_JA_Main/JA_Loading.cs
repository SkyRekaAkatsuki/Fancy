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
    public partial class JA_Loading : Form
    {
        public JA_Loading()
        {
            InitializeComponent();
            int int_tim = 0;
            Timer tim = new Timer();
            tim.Interval = 200;
            tim.Tick += (sender, e) => {
                int_tim++;
                if (int_tim > 3)
                    int_tim = 0;
                if (int_tim == 3)
                {
                    label_loading.Text = "Loading...";
                }
                else if (int_tim == 2)
                {
                    label_loading.Text = "Loading..";
                }
                else if (int_tim == 1)
                {
                    label_loading.Text = "Loading.";
                }
                else if (int_tim == 0)
                {
                    label_loading.Text = "Loading";
                }
            };
            tim.Start();

        }


        public void Close_this()
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
