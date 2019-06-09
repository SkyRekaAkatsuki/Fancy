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
    public partial class JA_統計 : Form
    {
        FancyStoreEntities db = new FancyStoreEntities();
        public JA_統計()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            db = new FancyStoreEntities();
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
            .Select(n => new { 地區 = n.Key, 人數 = n.Count() }).ToList();
            this.chart3.DataSource = 地區人數;
            this.chart3.Series[0].XValueMember = "地區";
            this.chart3.Series[0].YValueMembers = "人數";
            this.chart3.Series[0].Name = "人數";
            this.chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            var year = db.OrderDetails
                .OrderBy(n => n.CreateDate.Value.Year).Select(n => n.CreateDate.Value.Year)
                .Distinct().ToList();
            this.comboBox1.DataSource = year;

            var 中分類銷售比 = db.OrderDetails.AsEnumerable().Where(n => n.OrderHeader.OrderStatusID != 3)
                .GroupBy(n => n.Product.CategorySmall.CategoryMiddle.CategoryMName).Select
                (n => new { 中分類 = n.Key, 銷售額 = n.Sum(nn => nn.UnitPrice * nn.OrderQTY).ToString("C2") }).OrderByDescending(n => n.銷售額);
            this.chart6.DataSource = 中分類銷售比;
            this.chart6.Series[0].XValueMember = "中分類";
            this.chart6.Series[0].YValueMembers = "銷售額";
            this.chart6.Series[0].Name = "銷售額";
            this.chart6.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;


            var 小分類銷售比 = db.OrderDetails.AsEnumerable().Where(n => n.OrderHeader.OrderStatusID != 3)
                .GroupBy(n => n.Product.CategorySmall.CategorySName).Select
                (n => new { 小分類 = n.Key, 銷售額 = n.Sum(nn => nn.UnitPrice * nn.OrderQTY).ToString("C2") }).OrderByDescending(n => n.銷售額);
            this.chart7.DataSource = 小分類銷售比;
            this.chart7.Series[0].XValueMember = "小分類";
            this.chart7.Series[0].YValueMembers = "銷售額";
            this.chart7.Series[0].Name = "銷售額";
            this.chart7.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;



            var 供應商 = db.OrderDetails.AsEnumerable().Where(n => n.OrderHeader.OrderStatusID != 3)
            .GroupBy(n => n.Product.Supplier.SupplierName).Select
            (n => new { 供應商 = n.Key, 銷售額 = n.Sum(nn => nn.UnitPrice * nn.OrderQTY).ToString("C2") }).OrderByDescending(n => n.銷售額);
            this.chart8.DataSource = 供應商;
            this.chart8.Series[0].XValueMember = "供應商";
            this.chart8.Series[0].YValueMembers = "銷售額";
            this.chart8.Series[0].Name = "銷售額";
            this.chart8.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new FancyStoreEntities();
            var 年月銷售比 = db.OrderDetails.AsEnumerable().Where(n => n.CreateDate.Value.Year == ((Int32)((ComboBox)sender).SelectedItem)
            && n.OrderHeader.OrderStatusID != 3)
                .GroupBy(n => n.CreateDate.Value.Month).Select
                (n => new { 月 = $"{n.Key}月", 月銷售額 = n.Sum(nn => nn.UnitPrice * nn.OrderQTY).ToString("C2") }).OrderByDescending(n => n.月銷售額);
            this.chart4.DataSource = 年月銷售比;
            this.chart4.Series[0].XValueMember = "月";
            this.chart4.Series[0].YValueMembers = "月銷售額";
            this.chart4.Series[0].Name = "月銷售額";
            this.chart4.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart5.DataSource = 年月銷售比;
            this.chart5.Series[0].XValueMember = "月";
            this.chart5.Series[0].YValueMembers = "月銷售額";
            this.chart5.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            label1.Text = $"{年月銷售比.First().月}銷售額在今年銷售最高:{年月銷售比.First().月銷售額}";
            label2.Text = $"{年月銷售比.Last().月}銷售額在今年銷售最低:{年月銷售比.Last().月銷售額}";
        }
    }
}
