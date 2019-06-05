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
using UI_AL_ProductDetail;

namespace Ctr_Customs
{
    public partial class AL_ProductInfo : UserControl
    {

        public AL_ProductInfo()
        {
            InitializeComponent();
        }

        public EventHandler AddFav;
        public EventHandler RemoveFav;

        public string PName { set { label1.Text = value; } }
        public int PPrice { set { label2.Text = value.ToString(); } }
        public int ProductID { get; set; }
        public byte[] Picturebyte//set圖片的二進位資料
        {
            set
            {
                MemoryStream ms = new MemoryStream(value);
                pictureBox1.Image = Image.FromStream(ms);
                ms.Dispose();
            }
        }
        public bool like = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (like)
            {
                button1.Image = imageList1.Images[0];
                RemoveFav(sender, e);
            }
            else
            {
                button1.Image = imageList1.Images[1];
                AddFav(sender, e);
            }
            like = !like;
        }

        private void AL_ProductInfo_Load(object sender, EventArgs e)
        {
            if (like)
                button1.Image = imageList1.Images[1];
            else
                button1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[2];

            foreach (Control c in panel1.Controls)//設定元件的enter&leave
            {
                c.MouseEnter += AL_ProductInfo_MouseEnter;
                c.MouseLeave += AL_ProductInfo_MouseLeave;
                if (!(c is Button))//設定非按鈕的元件點擊觸發new form
                    c.Click += C_Click;
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            ProductDetail a = new ProductDetail(ProductID);
            a.ShowDialog();
        }

        private void AL_ProductInfo_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void AL_ProductInfo_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.AliceBlue;
        }
    }
}
