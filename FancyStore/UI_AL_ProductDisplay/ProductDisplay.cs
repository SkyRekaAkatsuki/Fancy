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
using Ctr_Customs;

namespace UI_AL_ProductDisplay
{
    public partial class ProductDisplay : Form
    {
        public ProductDisplay()
        {
            int CategoryLargeID = 1;
            InitializeComponent();
            LoadAll(CategoryLargeID);
            panel2.Left = flowLayoutPanel1.Left + 3;
        }

        void LoadAll(int CategoryLargeID)
        {
            var q = et.Products.Where(n => n.CategorySmall.CategoryMiddle.CategoryLarge.CategoryLID == CategoryLargeID).First();
            LoadM(CategoryLargeID);
            LoadS(q.CategorySmall.CategoryMiddle.CategoryMID);
            LoadProduct(q.CategorySID);
        }

        FancyStoreEntities et = new FancyStoreEntities();

        //void LoadL()
        //{
        //    var q = et.CategoryLarges.ToList();
        //    Button btn_L;
        //    foreach (var n in q)
        //    {
        //        btn_L = new Button
        //        {
        //            Name = n.CategoryLID.ToString(),
        //            Text = n.CategoryLName,
        //        };
        //        btn_L.Click += Btn_L_Click;
        //        flowLayoutPanel1.Controls.Add(btn_L);
        //    }
        //}

        //private void Btn_L_Click(object sender, EventArgs e)
        //{
        //    LoadM(int.Parse(((Button)sender).Name));
        //}

        void LoadM(int lid)//產生中分類
        {
            var q = et.CategoryMiddles.Where(n => n.CategoryLID == lid);
            Button btn_M;
            foreach (var n in q)
            {
                btn_M = new Button
                {
                    Name = n.CategoryMID.ToString(),
                    Text = n.CategoryMName,
                    Height = flowLayoutPanel1.Height,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("微軟正黑體", 12F, FontStyle.Bold),
                    Tag = n.CategoryMID
                };
                btn_M.FlatAppearance.BorderSize = 0;
                btn_M.Click += Btn_M_Click;
                flowLayoutPanel1.Controls.Add(btn_M);
                panel2.Top = btn_M.Height + flowLayoutPanel1.Top - 2;
            }
        }

        private void Btn_M_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            LoadS(int.Parse(((Button)sender).Name));
            LoadProduct(first);
            panel2.Left = flowLayoutPanel1.Left + ((Button)sender).Left;
        }

        int count;//紀錄次數
        int first;//紀錄預設顯示的商品
        int set;

        void LoadS(int mid)//產生小分類
        {
            count += 1;
            var q = et.CategorySmalls.Where(n => n.CategoryMID == mid);
            Button btn_S;
            foreach (var n in q)
            {
                btn_S = new Button
                {
                    Name = n.CategorySID.ToString(),
                    Text = n.CategorySName,
                    Width = flowLayoutPanel2.Width,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("微軟正黑體", 10F, FontStyle.Bold),
                    Tag = n.CategorySID,
                };
                if (set == 0)
                {
                    btn_S.BackColor = System.Drawing.Color.Orange;
                    set = 1;
                }
                if (count == 2)
                {
                    btn_S.BackColor = System.Drawing.Color.Orange;
                    first = n.CategorySID;//第一筆小分類的ID
                    count = 1;
                }
                btn_S.FlatAppearance.BorderSize = 0;
                btn_S.Click += Btn_S_Click;
                flowLayoutPanel2.Controls.Add(btn_S);
            }
            count = 1;
        }

        private void Btn_S_Click(object sender, EventArgs e)
        {
            foreach (Button b in flowLayoutPanel2.Controls)//點擊的那項改變顏色
            {
                b.BackColor = flowLayoutPanel2.BackColor;
            }
            ((Button)sender).BackColor = System.Drawing.Color.Orange;
            flowLayoutPanel3.Controls.Clear();
            LoadProduct(int.Parse(((Button)sender).Name));
        }

        void LoadProduct(int sid)//產生商品
        {
            var q = et.Products.Where(n => n.CategorySID == sid);
            AL_ProductInfo info;
            foreach (var n in q)
            {
                var q1 = et.ProductPhotoes.Where(m => m.ProductID == n.ProductID);
                var q2 = et.MyFavorites.Any(o => o.ProductID == n.ProductID);
                info = new AL_ProductInfo
                {
                    PName = n.ProductName,
                    PPrice = n.UnitPrice,
                    ProductID = n.ProductID,
                    Picturebyte = q1.First().Photo.Photo1
                };
                info.AddFav += (a, b) =>//委派加入我的最愛
                  {
                      et.MyFavorites.Add(new MyFavorite { UserID = Cls_Utility.Class1.UserID, ProductID = n.ProductID });
                      et.SaveChanges();
                  };
                info.RemoveFav += (a, b) =>//委派刪除我的最愛
                 {
                     var q3 = et.MyFavorites.Where(p => p.UserID == Cls_Utility.Class1.UserID && p.ProductID == n.ProductID).First();
                     et.MyFavorites.Remove(q3);
                     et.SaveChanges();
                 };
                if (q2)
                    info.like = true;
                else
                    info.like = false;
                flowLayoutPanel3.Controls.Add(info);
            }
        }
    }
}
