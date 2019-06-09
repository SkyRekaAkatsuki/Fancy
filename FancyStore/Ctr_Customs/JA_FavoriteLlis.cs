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
using Cls_Utility;
using UI_AL_ProductDetail;

namespace Ctr_Customs
{
    public partial class JA_FavoriteLlis : UserControl
    {
        public event Action 移除我的最愛成功;
        public byte[] _Ppic
        {
            set
            {
                using (MemoryStream ms = new MemoryStream(value))
                {
                    this.pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }
        public string _PName { set { this.label1.Text = value; } }
        private int PID;
        public int _PID { set { PID = value; } }
        public string _PPrice { set { this.label3.Text = value; } }

        public JA_FavoriteLlis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cls_JA_Member.RemoveFavorite((int)this.Tag))
            {
                Timer t = new Timer();
                t.Interval = 10;
                t.Start();
                int i = 0;
                t.Tick += (s, ee) =>
                {
                    if (i != 600)
                    {
                        i += 30;
                        this.panel3.Left += 30;
                    }
                    else
                    {
                        t.Stop();
                        i = 0;
                        if (移除我的最愛成功 != null)
                        {
                            移除我的最愛成功();
                        }
                        t.Dispose();
                    }
                };

        }
            else { return; }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ProductDetail productDetail = new ProductDetail(PID, Addcart);
            productDetail.ShowDialog();
        }

        void Addcart()
        {

        }
    }
}
