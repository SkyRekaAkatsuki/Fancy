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

namespace UI_AL_AddNews
{
    public partial class AddNews : Form
    {
        public AddNews()
        {
            InitializeComponent();
        }

        FancyStoreEntities et = new FancyStoreEntities();
        string plocation;

        void GetPicture(PictureBox p, byte[] photo)//讀取圖片
        {
            using (MemoryStream ms = new MemoryStream(photo))
                p.Image = Image.FromStream(ms);
        }

        byte[] data;

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                plocation = openFileDialog1.FileName;
                using (FileStream fs = new FileStream(plocation, FileMode.Open, FileAccess.Read))
                {
                    data = new byte[fs.Length];
                    fs.Read(data, 0, (int)fs.Length);
                    GetPicture(pictureBox1, data);
                }
            }
        }
        int photoid;

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var q1 = et.Photos.Any(n => n.Photo1 == data);
                if (q1)
                    MessageBox.Show("此圖片已存在圖庫中");
                else
                {
                    if (MessageBox.Show("確認新增", "新增", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        et.Photos.Add(new Photo { Photo1 = data, CreateDate = DateTime.Now });
                        et.SaveChanges();
                        var q = et.Photos.Where(n => n.Photo1 == data).Select(n => n.PhotoID).First();
                        label4.Text = q.ToString();
                        photoid = q;
                    }
                }
            }
            else
                MessageBox.Show("請先載入圖片");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || int.TryParse(label4.Text, out photoid) == false)
                MessageBox.Show("輸入資料有誤");
            else
            {
                if (MessageBox.Show("確認新增", "新增", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    et.NewsLists.Add(new DB_Fancy.NewsList { Title = textBox1.Text, NewsDate = DateTime.Now, NewContent = textBox2.Text, PhotoID = photoid });
                    et.SaveChanges();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var q1 = et.Photos.Any(n => n.Photo1 == data);
                if (q1)
                {
                    var q = et.Photos.Where(n => n.Photo1 == data).Select(n => n.PhotoID).First();
                    label4.Text = q.ToString();
                }
                else
                    MessageBox.Show("此圖片不存在圖庫中");
            }
            else
                MessageBox.Show("請先載入圖片");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }
    }
}