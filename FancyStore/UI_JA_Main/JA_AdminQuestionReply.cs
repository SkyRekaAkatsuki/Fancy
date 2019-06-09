using Cls_Utility;
using Ctr_Customs;
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
    public partial class JA_AdminQuestionReply : Form
    {
        public JA_AdminQuestionReply()
        {

            InitializeComponent();
            var q = Cls_JA_Member.db.Questions.Where(n => !n.IsRead).GroupBy(n => n.UserID)
                    .Select(n => new
                    {
                        UserId =n.Key,
                        Count = n.Count(),
                        Order = n.GroupBy(nn => nn.OrderHeader.OrderNum).Select(nn => new
                        {
                           OrderNum = nn.Key,
                            留言內容 = nn
                        })
                    });
            //這邊做左邊導覽列
            foreach (var item in q)
            {
                JA_AdminReplayLeft jA_AdminReplayLeft = new JA_AdminReplayLeft
                {
                    _Pname = Cls_JA_Member.db.Users.Find(item.UserId).UserName,
                    _Count = item.Count.ToString(),
                };
                jA_AdminReplayLeft.點擊 += () =>
                {
                    this.tabControl1.Controls.Clear();
                    foreach (var item2 in item.Order)
                    {
                        TabPage tp = new TabPage(item2.OrderNum.ToString());
                        tp.BorderStyle = BorderStyle.Fixed3D;
                        this.tabControl1.TabPages.Add(tp);
                        FlowLayoutPanel flow = new FlowLayoutPanel();
                        flow.Dock = DockStyle.Fill;
                        flow.AutoScroll = true;
                        tp.Controls.Add(flow);
                        foreach (var item3 in item2.留言內容)
                        {
                            JA_QuestionList list = new JA_QuestionList
                            {
                                問題 = item3.Question1,
                                回答 = item3.Answer,
                                創建時間 = item3.CreateDate,
                                Tag = item3.QuestionID,
                            };
                            flow.Controls.Add(list);
                            flow.ScrollControlIntoView(list);
                            Application.DoEvents();
                        }
                    }
                };
                flowLayoutPanel1.Controls.Add(jA_AdminReplayLeft);
            }
        }
    }
}
