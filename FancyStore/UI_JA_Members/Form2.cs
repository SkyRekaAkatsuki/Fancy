using Cls_Utility;
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

namespace UI_JA_Members
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Gender.SelectedIndex = 0;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IfMdown = false;
        }

        bool IfMdown = false;
        int NowX, NowY;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IfMdown)
            {
                this.Location = new Point(this.Left += e.X - NowX, this.Top += e.Y - NowY);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.jA_Input1.輸入塊字串 = "Jay";
            this.jA_Input2.輸入塊字串 = "123";
            this.jA_Input3.輸入塊字串 = "stepmania003@gmail.com";
            this.jA_Input4.輸入塊字串 = "0979325992";
            Gender.SelectedIndex = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            foreach (var item in SingUp_panel.Controls)
            {
                if (item is JA_Input)
                {
                    if (((JA_Input)item).輸入塊字串.Trim() == "")
                    {
                        MessageBox.Show("欄位不可空百");
                        return;
                    }
                }
            }

            string guid = Guid.NewGuid().ToString("N");
            User newuser = new User
            {
                UserName = this.jA_Input1.輸入塊字串,
                UserPassword = Cls_JA_IDo.HashPw(this.jA_Input2.輸入塊字串, guid),
                GUID = guid,
                Email = this.jA_Input3.輸入塊字串,
                Phone = this.jA_Input4.輸入塊字串,
                RegionID = 1,
                Address = "abc",
                RegistrationDate = DateTime.Now,
                Enabled = true,
                Gender = this.Gender.SelectedItem.ToString().Equals("男")
            };
            try
            {
                if (Cls_JA_Member.Register(newuser))
                {
                    MessageBox.Show("成功");
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cls_JA_Member.VaildateUser(this.textBox1.Text, this.textBox2.Text))
                {
                    MessageBox.Show("成功");
                }
                else { MessageBox.Show("失敗"); }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;

            foreach (var item in SingUp_panel.Controls)
            {
                if (item is JA_Input)
                {
                    ((JA_Input)item).輸入塊字串 = "";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.SingUp_panel.Left < 1000)
            {
                SingUp_panel.Left += 20;
            }
            else
            {
                if (Login_panel.Left > 490)
                {
                    Login_panel.Left -= 20;
                }
                else
                {
                    this.timer1.Enabled = false;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.SingUp_panel.Left > 490)
            {
                SingUp_panel.Left -= 20;
            }
            else
            {
                if (Login_panel.Left < 1000)
                {
                    Login_panel.Left += 20;
                }
                else { this.timer2.Enabled = false; }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.timer4.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.fg_panel.Left < 1000)
            {
                fg_panel.Left += 20;
            }
            else
            {
                if (Login_panel.Left > 490)
                {
                    Login_panel.Left -= 20;
                }
                else { this.timer3.Enabled = false; }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Action r = new Action(() => 
            {
                if (Login_panel.Left < 1000)
                {
                    Login_panel.Left += 20;
                }
                else
                {
                    if (this.fg_panel.Left > 490)
                    {
                        fg_panel.Left -= 20;
                    }
                    else { this.timer4.Enabled = false; }
                }
            });
            r();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Cls_JA_Member.ForgotPassword(textBox4.Text, textBox3.Text))
            {
                MessageBox.Show("新密碼成功寄出");
                this.timer3.Enabled = true;
                textBox4.Text = textBox3.Text = "";
            }
            else { MessageBox.Show("資料錯誤"); }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IfMdown = true;
            NowX = e.X;
            NowY = e.Y;
        }

    }
}
;