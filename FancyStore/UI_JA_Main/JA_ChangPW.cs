using Cls_Utility;
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
    public partial class JA_ChangPW : Form
    {
        public JA_ChangPW()
        {
            InitializeComponent();
        }

        private void B_更改密碼_Click(object sender, EventArgs e)
        {
            if (Cls_JA_Member.VaildateUser(jA_Input1.輸入塊字串, jA_Input2.輸入塊字串))
            {
                this.新密碼_P.Visible = true;
                this.timer1.Start();
                int i = 0;
                this.timer1.Tick += delegate
                {
                    if (i<=350)
                    {
                        i += 10;
                        this.驗證舊密碼_P.Left -= 10;
                        this.新密碼_P.Top -= 10;
                    }
                    else
                    {
                        i = 0;
                        this.驗證舊密碼_P.Visible = false;
                        this.timer1.Stop();
                    }
                };
            }
            else { MessageBox.Show("資料錯誤"); };
        }

        async private void 新密碼_B_Click(object sender, EventArgs e)
        {
            try
            {
                this.新密碼_B.Enabled = false;
                this.label1.Visible = true;
                Timer t1 = new Timer();
                int i = 0;
                t1.Interval = 500;
                t1.Start();
                t1.Tick += delegate
                {
                    if (i != 3)
                    {
                        this.label1.Text += ".";
                        i++;
                    }
                    else
                    {
                        i = 0;
                        this.label1.Visible = false;
                        t1.Stop();
                    }
                };
                await Task.Run(() => Cls_JA_Member.SendAuthCode(this.jA_Input3.輸入塊字串, this.jA_Input1.輸入塊字串));
                this.驗證碼_P.Visible = true;
                Timer t = new Timer();
                t.Interval = 10;
                t.Start();
                t.Tick += delegate
                {
                    if (i<=350)
                    {
                        i += 10;
                        this.新密碼_P.Left -= 10;
                        this.驗證碼_P.Top -= 10;
                    }
                    else
                    {
                        i = 0;
                        this.新密碼_P.Visible = false;
                        t.Stop();
                    }
                };
            }
            catch (Exception)
            {
                throw;
            }

        }
        public event Action 密碼更改成功;
        private void 驗證碼_B_Click(object sender, EventArgs e)
        {
            if (Cls_JA_Member.CheckAuthCode(this.jA_Input4.輸入塊字串))
            {
                Cls_JA_Member.UpdatePassword(this.jA_Input3.輸入塊字串, this.jA_Input1.輸入塊字串);
                MessageBox.Show("更改成功，請重新登入");
                if (密碼更改成功 != null)
                {
                    密碼更改成功();
                    this.Close();
                }
            }

        }


    }
}
