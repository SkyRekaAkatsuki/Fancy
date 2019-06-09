using Cls_Utility;
using Ctr_Customs;
using DB_Fancy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_JA_Main
{
    public partial class JA_Favorite : Form
    {
        public JA_Favorite()
        {
            InitializeComponent();
            var userFavorite = Cls_JA_Member.db.MyFavorites.Where(n => n.UserID == Cls_JA_Member.UserID).Select(n => n);

            foreach (var item in userFavorite)
            //for (int i = 0; i <= 10; i++)
            {
                JA_FavoriteLlis list = new JA_FavoriteLlis
                {
                    _PName = item.Product.ProductName,
                    _PID = item.ProductID,
                    _PPrice = item.Product.UnitPrice.ToString("C2"),
                    Tag = item.FavoriteID,
                    _Ppic = item.Product.ProductPhotoes.Select(n => n.Photo.Photo1).First()
                };

                list.移除我的最愛成功 += delegate
                {
                    Timer t = new Timer();
                    t.Interval = 10;
                    t.Start();
                    int ii = 0;
                    t.Tick += (s, ee) =>
                    {
                        if (ii != 100)
                        {
                            ii += 10;
                            list.Height -= 10;
                        }
                        else
                        {
                            t.Stop();
                            flowLayoutPanel1.Controls.Remove(list);
                            t.Dispose();
                        }
                    };
                };

                flowLayoutPanel1.Controls.Add(list);
                Application.DoEvents();
            };

        }
    }
}
