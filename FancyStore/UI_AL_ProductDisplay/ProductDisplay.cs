using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;

namespace UI_AL_ProductDisplay
{
    public partial class ProductDisplay : Form
    {
        public ProductDisplay()
        {
            InitializeComponent();
            LoadL();
        }

        FancyStoreEntities et = new FancyStoreEntities();

        void LoadL()
        {
            var q = et.CategoryLarges.ToList();
            Button btn_L;
            foreach (var n in q)
            {
                btn_L = new Button
                {
                    Name = n.CategoryLID.ToString(),
                    Text = n.CategoryLName
                };
                btn_L.Click += Btn_L_Click;
            }
        }

        private void Btn_L_Click(object sender, EventArgs e)
        {
            LoadM(int.Parse(((Button)sender).Name));
        }

        void LoadM(int lid)
        {
            var q = et.CategoryMiddles.Where(n => n.CategoryLID == lid);
            Button btn_M;
            foreach (var n in q)
            {
                btn_M = new Button
                {
                    Name = n.CategoryMID.ToString(),
                    Text = n.CategoryMName
                };
                btn_M.Click += Btn_M_Click;
            }
        }

        private void Btn_M_Click(object sender, EventArgs e)
        {
            LoadS(int.Parse(((Button)sender).Name));
        }

        void LoadS(int mid)
        {
            var q = et.CategorySmalls.Where(n => n.CategoryMID == mid);
            foreach (var n in q)
            {
                Button btn_S = new Button
                {
                    Name = n.CategorySID.ToString(),
                    Text = n.CategorySName
                };
                btn_S.Click += Btn_S_Click;

            }
        }

        private void Btn_S_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (click)
            {
                do { flowLayoutPanel1.Height -= 1; }
                while (flowLayoutPanel1.Height >0);
            }
            else
            {
                do { flowLayoutPanel1.Height += 1; }
                while (flowLayoutPanel1.Height <100);
            }
        }
        bool click;
        private void button1_Click(object sender, EventArgs e)
        {
            click = !click;
            timer1.Enabled = true;
        }
    }
}
