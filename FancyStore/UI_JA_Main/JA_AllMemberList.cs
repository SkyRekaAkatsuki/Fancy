using Cls_Utility;
using Ctr_Customs;
using DB_Fancy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_EW_Maintain;

namespace UI_JA_Main
{
    public partial class JA_AllMemberList : Form
    {
        public JA_AllMemberList()
        {
            InitializeComponent();
            this.textBox1.Focus();
            this.textBox1.SelectAll();
            this.textBox1.Text = "搜尋使用者ID";
            LoadList(Cls_JA_Member.db.Users.ToList());
        }
        bool IdB;
        private void button1_Click(object sender, EventArgs e)
        {
            IdB = !IdB;
            if (IdB)
            {
                this.button1.Image = IconPIc.icons8_up_24;
                LoadList(Cls_JA_Member.db.Users.OrderByDescending(n => n.UserID).ToList());
            }
            else
            {
                this.button1.Image = IconPIc.icons8_down_arrow_24;
                LoadList(Cls_JA_Member.db.Users.OrderBy(n => n.UserID).ToList());
            }
        }

        bool IddB;
        private void button6_Click(object sender, EventArgs e)
        {
            IddB = !IddB;
            if (IddB)
            {
                this.button6.Image = IconPIc.icons8_up_24;
                LoadList(Cls_JA_Member.db.Users.OrderByDescending(n => n.RegistrationDate).ToList());
            }
            else
            {
                this.button6.Image = IconPIc.icons8_down_arrow_24;
                LoadList(Cls_JA_Member.db.Users.OrderBy(n => n.RegistrationDate).ToList());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                foreach (var item in this.flowLayoutPanel1.Controls)
                {
                    ((JA_MemberList)item).Visible = true;
                }
                return;
            }
            foreach (var item in this.flowLayoutPanel1.Controls)
            {
                if (((JA_MemberList)item)._ID == this.textBox1.Text)
                {
                    ((JA_MemberList)item).Visible = true;
                }
                else { ((JA_MemberList)item).Visible = false; }
            }
        }

        private void LoadList(List<User> data)
        {
            this.flowLayoutPanel1.Controls.Clear();
            foreach (var item in data)
            {
                byte[] q;
                if (item.PhotoID == null)
                { q = Cls_JA_Member.db.Photos.Where(n => n.PhotoID == 1).Select(n => n.Photo1).First(); }
                else
                { q = item.Photo.Photo1; }

                JA_MemberList list = new JA_MemberList
                {
                    _ID = item.UserID.ToString(),
                    _Name = item.UserName,
                    _City = item.Region.City.CityName,
                    _Region = item.Region.RegionName,
                    _RegisterTime = item.RegistrationDate.ToString(),
                    _使用者密碼 = item.UserPassword.ToString(),
                    _開通用驗證碼 = item.VerificationCode,
                    _權限 = item.Admin,
                    _Enabled = item.Enabled,
                    _PColor = System.Drawing.Color.FromArgb(188, 171, 143),
                    _相片 = q,
                    _Email = item.Email,
                    Height = 60
                };

                list.資料更動 += delegate
                {
                    LoadList(Cls_JA_Member.db.Users.ToList());
                };
                this.flowLayoutPanel1.Controls.Add(list);
                Application.DoEvents();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            JA_統計 chart = new JA_統計();
            chart.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmBackMain frmBackMain = new FrmBackMain();
            frmBackMain.Show();
        }


        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text="";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            JA_AdminQuestionReply reply = new JA_AdminQuestionReply();
            reply.ShowDialog();
        }
    }
}
