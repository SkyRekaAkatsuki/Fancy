using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_EW_Maintain
{
    public partial class FrmBackMain : Form
    {
        public FrmBackMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategoryL f = new FrmCategoryL();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmColor f = new FrmColor();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmSize f = new FrmSize();
            f.Show();
        }
    }
}
