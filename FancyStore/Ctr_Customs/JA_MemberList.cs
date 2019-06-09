using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_Utility;
using System.Runtime.InteropServices;
using System.IO;

namespace Ctr_Customs
{
    public partial class JA_MemberList : UserControl
    {

        public event Action 資料更動;


        //Cls_JA_Members Loginusers = new Cls_JA_Members();

        public JA_MemberList()
        {
            InitializeComponent();
        }
        public string _ID
        {
            get
            { return this.UserID.Text; }
            set { this.UserID.Text = value; }
        }
        public string _Name
        {
            get
            { return this.UserName.Text; }
            set { this.UserName.Text = value; }
        }
        public string _City
        {
            get
            { return this.City.Text; }
            set { this.City.Text = value; }
        }

        public string _Region
        {
            get
            { return this.MYRegion.Text; }
            set { this.MYRegion.Text = value; }
        }

        public string _RegisterTime
        {
            get
            { return this.RegisterTIme.Text; }
            set { this.RegisterTIme.Text = value; }
        }
        public string _使用者密碼
        {
            get
            { return this.使用者密碼.輸入塊字串; }
            set { this.使用者密碼.輸入塊字串 = value; }
        }

        public string _開通用驗證碼
        {
            get
            { return this.開通用驗證碼.輸入塊字串; }
            set { this.開通用驗證碼.輸入塊字串 = value; }
        }
        private string Email;
        public string _Email
        {
            get
            { return _Email; }
            set { Email = value; }
        }
        public bool _權限
        {
            get
            {
                if (this.權限.SelectedItem.ToString() == "管理員")
                { return true; }
                else { return false; }
            }
            set
            {
                if (value)
                { this.權限.SelectedIndex = 1; }
                else { this.權限.SelectedIndex = 0; }
            }
        }
        Image picg;
        public byte[] _相片
        {
            set
            {
                using (MemoryStream ms = new MemoryStream(value))
                {
                    this.UserImg.Image = Image.FromStream(ms);
                }
                picg = this.UserImg.Image;
            }
        }

        public bool _Enabled
        {
            get
            {
                return this.刪除_B.Text == "管制";
            }
            set
            {
                if (value)
                {
                    this.刪除_B.Text = "管制";
                    this.刪除_B.BackColor = Color.FromArgb(0, 179, 45);
                }
                else
                {
                    this.刪除_B.BackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
                    this.刪除_B.Text = "復活";
                }
            }
        }
        public Color _PColor
        {
            set
            { this.panel1.BackColor = value; }
        }



        private void 刪除_B_MouseLeave(object sender, EventArgs e)
        {
            //Timer t = new Timer();
            //t.Interval = 10;

            //t.Start();
            //t.Tick += delegate
            //{
            //    //if (this.刪除_B.Left != 710)
            //    //{
            //        this.刪除_B.Left = 710;
            //    //}
            //    //else
            //    //{
            //        //t.Stop();
            //        //t.Dispose();
            //    //}
            //};
        }

        private void 刪除_B_MouseEnter(object sender, EventArgs e)
        {
            //Timer t = new Timer();
            //t.Interval = 10;

            //t.Start();
            //t.Tick += delegate
            //{
            //    if (this.刪除_B.Left != 660)
            //    {
            //this.刪除_B.Left = 660;
            //}
            //else
            //{
            //    t.Stop();
            //    t.Dispose();
            //}
            //};
        }


        bool userCheck = false;
        private void 展開_Click(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 10;
            userCheck = !userCheck;
            t.Start();
            t.Tick += delegate
            {
                if (userCheck)
                {
                    this.展開.Text = "收回";
                    this.展開.Image = img.icons8_collapse_arrow_24;
                    if (this.Height != 120)
                    { this.Height += 10; }
                    else
                    { t.Stop(); }
                }
                else
                {
                    this.展開.Text = "展開";
                    this.展開.Image = img.icons8_expand_arrow_24;
                    if (this.Height != 60)
                    { this.Height -= 10; }
                    else
                    { t.Stop(); }
                }
            };
        }

        private void JA_MemberList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"確定要修改ID為 :[ {this._ID} ]這位使用者的密碼嗎?",
                "提醒你", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (this.使用者密碼.輸入塊字串.Trim() != String.Empty)
                {
                    if (Cls_JA_Admin.UpdateUserPassword(Int32.Parse(this._ID), _使用者密碼))
                    {
                        MessageBox.Show("成功");
                        if (資料更動 != null)
                        {
                            資料更動();
                        }
                    }
                    else { MessageBox.Show("失敗"); }
                }
                else { MessageBox.Show("輸入新密碼"); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"確定要更改ID為 :[ {this._ID} ]這位使用者的驗證碼嗎?",
                    "提醒你", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (Cls_JA_Admin.UpdateUserAcode(Int32.Parse(this._ID), _開通用驗證碼))
                {
                    MessageBox.Show("成功");
                    if (資料更動 != null)
                    {
                        資料更動();
                    }
                }
                else { MessageBox.Show("失敗"); }
            }
        }

        private void 刪除_B_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"確定要管制ID為 :[ {this._ID} ]這位使用者嗎?",
                                "提醒你", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (Cls_JA_Admin.DeleteUser(Int32.Parse(this._ID), _Enabled))
                {

                    MessageBox.Show("成功");


                    if (資料更動 != null)
                    {
                        資料更動();
                    }
                }
                else { MessageBox.Show("失敗"); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"確定要變更ID為 :[ {this._ID} ]這位使用者的權限嗎?",
                                "提醒你", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (Cls_JA_Admin.UpdateUserAdmin(Int32.Parse(this._ID), this._權限))
                {
                    MessageBox.Show("成功");
                    if (資料更動 != null)
                    {
                        資料更動();
                    }
                }
                else { MessageBox.Show("失敗"); }
            }
        }

        private void SEmail_Click(object sender, EventArgs e)
        {
            JA_EmailWindows jA_EmailWindows = new JA_EmailWindows(Email, _Name, picg);
            jA_EmailWindows.ShowDialog();
        }
    }
}
