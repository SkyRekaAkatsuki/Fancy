using Cls_Utility;
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
            LoadDetail(ProductID);
            LoadWash(ProductID);
            LoadColor(ProductID);
            LoadSize(ProductID);
            LoadImage(ProductID);
            Checkqty();
            panel1.Left = flowLayoutPanel2.Left + 3;
            panel2.Left = flowLayoutPanel3.Left + 3;
        }

        int colordefault;//記預設點選顏色
        int sizedefault;//記預設點選尺寸
        int itemID;//記購買產品ID
        string itemName;
        int itemCategorySID;//記購買產品S分類
        int itemSizeID;//記購買產品尺寸
        string itemSizeName;
        int itemColorID;//記購買產品顏色
        string itemColorName;
        decimal itemUnitPrice;

        FancyStoreEntities et = new FancyStoreEntities();
        int count;

        void LoadDetail(int ProductID)
        {
            var q = et.Products.Where(n => n.ProductID == ProductID).First();
            label1.Text = q.ProductName;//商品名
            label2.Text = q.Desctiption;//商品敘述
            label3.Text = q.UnitPrice.ToString("C2");//商品價錢

            itemID = q.ProductID;
            itemName = q.ProductName;
            itemCategorySID = q.CategorySID;
            itemUnitPrice = q.UnitPrice;
        }

        void LoadWash(int ProductID)
        {
            var q2 = et.ProductWashings.Where(m => m.ProductID == ProductID);
            foreach (var n in q2)//產生洗滌資訊
            {
                Label w = new Label();
                w.AutoSize = false;
                w.Width = flowLayoutPanel1.Width;
                w.Font = new Font("微軟正黑體", 10F);
                w.Text = n.Washing.WashingName;
                flowLayoutPanel1.Controls.Add(w);
            }
        }

        void LoadColor(int ProductID)
        {
            var q3 = et.ProductColors.Where(m => m.ProductID == ProductID);
            foreach (var n in q3)//產生商品顏色
            {
                Button c = new Button();
                c.Name = n.Color.ColorName;
                c.BackColor = System.Drawing.Color.FromArgb((int)n.Color.R, (int)n.Color.G, (int)n.Color.B);
                c.Tag = n.ProductColorID;
                c.FlatStyle = FlatStyle.Flat;
                c.FlatAppearance.BorderSize = 0;
                toolTip1.SetToolTip(c, n.Color.ColorName);
                c.MouseEnter += C_Enter;
                c.Click += C_Click;
                flowLayoutPanel2.Controls.Add(c);
                panel1.Top = flowLayoutPanel2.Top + c.Height + c.Top - 4;
                if (colordefault == 0)//預設顏色
                {
                    itemColorID = (int)c.Tag;
                    itemColorName = c.Name;
                    colordefault = 1;
                }
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            panel1.Left = ((Button)sender).Left + flowLayoutPanel2.Left;
            panel1.Top = ((Button)sender).Top + ((Button)sender).Height + flowLayoutPanel2.Top - 4;
            itemColorID = (int)((Button)sender).Tag;
            itemColorName = ((Button)sender).Name;
            Checkqty();
        }

        private void C_Enter(object sender, EventArgs e)//觸碰顏色改照片
        {
            var q = et.Photos.Where(m => m.PhotoID == (int)((Button)sender).Tag).Select(m => m.Photo1);
            GetPicture(pictureBox1, q.First());
        }

        void LoadSize(int ProductID)
        {
            var q4 = et.ProductSizes.Where(m => m.ProductID == ProductID);
            foreach (var n in q4)//產生商品尺寸
            {
                Button s = new Button();
                s.Name = n.Size.SizeName;
                s.BackColor = System.Drawing.Color.GhostWhite;
                s.Text = n.Size.SizeName;
                s.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
                s.Tag = n.SizeID;
                s.FlatStyle = FlatStyle.Flat;
                s.FlatAppearance.BorderSize = 0;
                s.Click += S_Click;
                flowLayoutPanel3.Controls.Add(s);
                panel2.Top = flowLayoutPanel3.Top + s.Height + s.Top - 4;
                if (sizedefault == 0)//預設尺寸
                {
                    itemSizeID = (int)s.Tag;
                    itemSizeName = s.Name;
                    sizedefault = 1;
                }
            }
        }

        private void S_Click(object sender, EventArgs e)
        {
            panel2.Left = ((Button)sender).Left + flowLayoutPanel3.Left;
            itemSizeID = (int)((Button)sender).Tag;
            itemSizeName = ((Button)sender).Name;
            Checkqty();
        }

        void LoadImage(int ProductID)
        {
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
                if (count == 0)
                {
                    GetPicture(pictureBox1, n.Photo.Photo1);
                    count = 1;
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            CartItem item = new CartItem();
            item.UserID = Cls_JA_Member.UserID;
            item.ProductID = itemID;
            item.ProductName = itemName;
            item.CategorySID = itemCategorySID;
            item.ProductSizeID = itemSizeID;
            item.ProductSizeName = itemSizeName;
            item.ProductColorID = itemColorID;
            item.ProductColorName = itemColorName;
            item.Qty = (int)numericUpDown1.Value;
            item.UnitPrice = itemUnitPrice;
            Cls_Utility.Class1.CartList.Add(item);
            MessageBox.Show("加入成功");
            Checkqty();
            //Addcart.Invoke();//觸發委派的方法
        }

        void Checkqty()
        {
            try
            {
                var q = et.ProductStocks.Where(n => n.ProductColorID == itemColorID && n.ProductSizeID == itemSizeID).First();
                if (q.StockQTY != 0)
                {
                    button1.Enabled = true;
                    button1.Text = "加入購物車";
                    numericUpDown1.Enabled = true;
                    numericUpDown1.Maximum = q.StockQTY;
                }
                else
                {
                    button1.Enabled = false;
                    button1.Text = "庫存不足";
                    numericUpDown1.Enabled = false;
                }
                numericUpDown1.Value = 1;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("庫存沒資料");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Cls_Utility.Class1.CartList;
        }
    }
}
