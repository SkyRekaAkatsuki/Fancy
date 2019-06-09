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

namespace Ctr_Customs
{
    public partial class JA_OrderDetail : Form
    {
        public int OrderID { get; set; }
        public JA_OrderDetail()
        {
            InitializeComponent();
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {

            int? DetailAmount = Cls_JA_Member.db.OrderDetails.Where(n => n.OrderID == OrderID)
                    .Sum(n => n.OrderQTY * n.UnitPrice);
            label7.Text = DetailAmount.ToString();
            label1.Text = this.Name;
            foreach (var item in Cls_JA_Member.db.OrderDetails.Where(n => n.OrderID == OrderID))
            {
                JA_OrderDetailList orderDetailList = new JA_OrderDetailList
                {
                    _pname = item.Product.ProductName,
                    _pcolor = item.ProductColor.Color.ColorName,
                    _size = item.ProductSize.Size.SizeName,
                    _qty = item.OrderQTY.ToString(),
                    _up = item.UnitPrice.ToString(),
                    _小計 = (item.UnitPrice * item.OrderQTY).ToString(),
                };
                this.flowLayoutPanel1.Controls.Add(orderDetailList);
            }
            foreach (var item in Cls_JA_Member.db.Questions.Where(n => n.OrderID == OrderID).OrderBy(n => n.CreateDate))
            {
                JA_QuestionList list = new JA_QuestionList
                {
                    問題 = item.Question1,
                    回答 = item.Answer,
                    創建時間 = item.CreateDate,
                    Tag = item.QuestionID,
                };
                this.flowLayoutPanel2.Controls.Add(list);
                this.flowLayoutPanel2.ScrollControlIntoView(list);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "")
            {
                JA_QuestionList list = new JA_QuestionList
                {
                    問題 = textBox1.Text,
                    回答 = "",
                    創建時間 = DateTime.Now
                };
                Question Newquestion = new Question
                {
                    OrderID = this.OrderID,
                    UserID = Cls_JA_Member.UserID,
                    Question1 = textBox1.Text,
                    CreateDate = DateTime.Now
                };

                Cls_JA_Member.AddQuestion(OrderID, Newquestion);
                this.flowLayoutPanel2.Controls.Add(list);
                this.flowLayoutPanel2.ScrollControlIntoView(list);
            }
        }
    }
}
