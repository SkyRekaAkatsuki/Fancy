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

namespace UI_AL_AddNews
{
    public partial class NewsList : Form
    {
        public NewsList()
        {
            InitializeComponent();
            var q = et.NewsLists;

            foreach (var n in q)
            {
                flowLayoutPanel1.Controls.Add(new AL_NewsInfo { NewsID = n.NewsID, Title = n.Title, NewsDate = (DateTime)n.NewsDate, NewsContent = n.NewContent, PhotoID = (int)n.PhotoID });
            }
        }
        FancyStoreEntities et = new FancyStoreEntities();


    }
}
