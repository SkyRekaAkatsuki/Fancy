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

namespace UI_JA_Main
{
    public partial class 統計 : Form
    {
        public 統計()
        {
            InitializeComponent();


        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            FancyStoreEntities db = new FancyStoreEntities();
            RegisterNum.Text = db.Users.AsEnumerable().Count(n =>
            n.RegistrationDate.ToShortDateString() == DateTime.Now.ToShortDateString()).ToString();

            var 每日會員成長 = db.Users.AsEnumerable().GroupBy(n => n.RegistrationDate.ToShortDateString())
            .Select(n => new { 天 = n.Key, 人數 = n.Count() }).ToList();
            this.chart1.DataSource = 每日會員成長;
            this.chart1.Series[0].XValueMember = "天";
            this.chart1.Series[0].YValueMembers = "人數";
            this.chart1.Series[0].Name = "人數";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            var 性別占比 = Cls_JA_Member.db.Users.GroupBy(n => n.Gender == true ? "男性" : "女性").
                Select(n => new { 性別 = n.Key, 人數 = n.Count() }).ToList();
            this.chart2.DataSource = 性別占比;
            this.chart2.Series[0].XValueMember = "性別";
            this.chart2.Series[0].YValueMembers = "人數";
            this.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            var 地區人數 = db.Users.GroupBy(n => n.Region.City.CityName)
            .Select(n => new  { 地區 = n.Key, 人數 = n.Count() }).ToList();
            this.chart3.DataSource = 地區人數;
            this.chart3.Series[0].XValueMember = "地區";
            this.chart3.Series[0].YValueMembers = "人數";
            this.chart3.Series[0].Name = "人數";
            this.chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;



        }
    }
}
