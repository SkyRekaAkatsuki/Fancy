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
using DB_Fancy;

namespace Ctr_Customs
{
    public partial class JA_QuestionList : UserControl
    {

        public string 問題
        {
            set
            {
                label2.Text = value;
            }
        }
        public string 回答
        {
            set
            {
                label1.Text = value;
            }
                
        }
        public DateTime? 創建時間
        {
            set
            {
                this.label3.Text = value.Value.ToString("yyyy-MM-dd");
            }

        }
        public JA_QuestionList()
        {
            InitializeComponent();

            if (Cls_JA_Member.IsAdmin)
            {
                button2.Enabled = true;
                panel3.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() != "")
            {
                Question q = Cls_JA_Member.db.Questions.Find(this.Tag);
                q.Answer = this.textBox1.Text;
                q.IsRead = true;
                Cls_JA_Member.db.SaveChanges();
                label1.Text = this.textBox1.Text;
                this.BackColor = System.Drawing.Color.Red;
                panel3.Visible = false;
            }
            else { MessageBox.Show("請輸入內容", "提醒"); }
        }
    }
}
