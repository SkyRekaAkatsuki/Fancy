using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ctr_Customs
{
    public partial class JA_EmailWindows : Form
    {
        string Email;
        string _Name;
        public JA_EmailWindows(string email, string name, Image _相片)
        {
            InitializeComponent();
            Email = email;
            _Name = name;

            this.pictureBox1.Image = _相片;
            this.label1.Text = _Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() != String.Empty)
            {
                Cls_Utility.Cls_JA_IDo.SendEmail(Email, _Name, this.textBox1.Text);
                MessageBox.Show("已送出");
            }
            else { MessageBox.Show("請輸入訊息"); }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
