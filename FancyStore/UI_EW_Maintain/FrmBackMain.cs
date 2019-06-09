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
        //大分類
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategoryL f = new FrmCategoryL();
            f.Show();
        }
        //顏色
        private void button4_Click(object sender, EventArgs e)
        {
            FrmColor f = new FrmColor();
            f.Show();
        }
        //尺吋大小
        private void button5_Click(object sender, EventArgs e)
        {
            FrmSize f = new FrmSize();
            f.Show();
        }
        //中分類
        private void button2_Click(object sender, EventArgs e)
        {
            FrmCategoryM f = new FrmCategoryM();
            f.Show();
        }
        //小分類
        private void button3_Click(object sender, EventArgs e)
        {
            FrmCategoryS f = new FrmCategoryS();
            f.Show();
        }
        //產品資料
        private void button6_Click(object sender, EventArgs e)
        {
            FrmProducts f = new FrmProducts();
            f.Show();
        }
        //補貨
        private void button7_Click(object sender, EventArgs e)
        {
            FrmAddStock f = new FrmAddStock();
            f.Show();
        }
        //上下架
        private void button8_Click(object sender, EventArgs e)
        {
            FrmInOut f = new FrmInOut();
            f.Show();
        }
        //訂單出貨
        private void button9_Click(object sender, EventArgs e)
        {
            FrmShipment f = new FrmShipment();
            f.Show();
        }
    }
}
