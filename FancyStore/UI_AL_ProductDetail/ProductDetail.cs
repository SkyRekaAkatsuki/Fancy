using DB_Fancy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI_AL_ProductDetail
{
    public partial class ProductDetail : Form
    {
        public ProductDetail(int ProductID)
        {
            InitializeComponent();
            var q = et.Products.Where(n => n.ProductID == ProductID).First();
            label1.Text = q.ProductName;//商品名
            label2.Text = q.Desctiption;//商品敘述
            label3.Text = q.UnitPrice.ToString();//商品價錢
            var q2 = et.ProductWashings.Where(m => m.ProductID == ProductID);
            foreach (var n in q2)//產生洗滌資訊
            {
                Label w = new Label();
                w.AutoSize = false;
                w.Width = flowLayoutPanel1.Width;
                //w.AutoEllipsis = true;
                w.Text = n.Washing.WashingName;
                flowLayoutPanel1.Controls.Add(w);
            }
            var q3 = et.ProductColors.Where(m => m.ProductID == ProductID);
            foreach (var n in q3)//產生商品顏色
            {
                Button c = new Button();
                c.BackColor = System.Drawing.Color.FromArgb((int)n.Color.R, (int)n.Color.G, (int)n.Color.B);
                c.Tag = n.PhotoID;
                c.MouseEnter += C_Enter;
                flowLayoutPanel2.Controls.Add(c);
            }
            var q4 = et.ProductSizes.Where(m => m.ProductID == ProductID);
            foreach (var n in q4)//產生商品尺寸
            {
                Button s = new Button();
                s.Text = n.Size.SizeName;
                flowLayoutPanel3.Controls.Add(s);
            }
            var q5 = et.ProductPhotoes.Where(m => m.ProductID == ProductID);
            foreach (var n in q5)//產生商品照片
            {
                PictureBox p = new PictureBox();
                p.Height = 50;
                p.Width = 50;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Tag = n.Photo.Photo1;
                GetPicture(p, n.Photo.Photo1);
                p.MouseEnter += P_MouseEnter;
                flowLayoutPanel4.Controls.Add(p);
            }
        }

        private void P_MouseEnter(object sender, EventArgs e)//觸碰圖片改照片
        {
            GetPicture(pictureBox1, (byte[])((PictureBox)sender).Tag);
        }

        void GetPicture(PictureBox p, byte[] photo)//讀取圖片
        {
            MemoryStream ms = new MemoryStream(photo);
            p.Image = Image.FromStream(ms);
            ms.Dispose();
        }

        private void C_Enter(object sender, EventArgs e)//觸碰顏色改照片
        {
            var q = et.Photos.Where(m => m.PhotoID == (int)((Button)sender).Tag).Select(m => m.Photo1);
            GetPicture(pictureBox1, q.First());
        }

        FancyStoreEntities et = new FancyStoreEntities();
    }
}
