using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;

namespace UI_AL_Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            var q = et.NewsLists.ToList();
            foreach (var n in q)
            {
                picturelist.Add(n.Photo.Photo1);
            }
            Addnews();
        }

        FancyStoreEntities et = new FancyStoreEntities();
        List<byte[]> picturelist = new List<byte[]>();

        void GetPicture(PictureBox p, byte[] photo)//讀取圖片
        {
            MemoryStream ms = new MemoryStream(photo);
            p.Image = Image.FromStream(ms);
            ms.Dispose();
            GC.Collect();
        }

        void Addnews()
        {
            //var q = et.NewsLists.ToList();
            foreach (var n in picturelist)
            {
                PictureBox banner = new PictureBox { Width = 1051, Height = 530, Margin = new Padding(0), Padding = new Padding(0), BorderStyle = BorderStyle.None, SizeMode = PictureBoxSizeMode.StretchImage };
                GetPicture(banner, n);
                flowLayoutPanel1.Controls.Add(banner);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int count = 0;
            foreach (PictureBox p in flowLayoutPanel1.Controls)
            {
                //p.MouseHover += P_MouseHover;
                //p.MouseLeave += P_MouseLeave;
                if (count == 0)
                {
                    if (p.Width <= 0)
                    {
                        Timer1_stop();
                        flowLayoutPanel1.Controls.Remove(p);
                        p.Dispose();
                        if (flowLayoutPanel1.Controls.Count <= 2)
                        {
                            Addnews();
                            MessageBox.Show("add");
                        }
                    }
                    else
                        p.Width -= 64;
                }
                count = 1;
            }
        }

        private void P_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void P_MouseHover(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        void Timer1_stop()
        {
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }
    }
}
