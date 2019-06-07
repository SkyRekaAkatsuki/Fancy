namespace UI_JA_Main
{
    partial class 統計
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.每日趨勢 = new System.Windows.Forms.TabPage();
            this.TotalMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.男女分布 = new System.Windows.Forms.TabPage();
            this.地區分布 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.每日趨勢.SuspendLayout();
            this.男女分布.SuspendLayout();
            this.地區分布.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.每日趨勢);
            this.tabControl1.Controls.Add(this.男女分布);
            this.tabControl1.Controls.Add(this.地區分布);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 533);
            this.tabControl1.TabIndex = 1;
            // 
            // 每日趨勢
            // 
            this.每日趨勢.Controls.Add(this.label3);
            this.每日趨勢.Controls.Add(this.label1);
            this.每日趨勢.Controls.Add(this.TotalMoney);
            this.每日趨勢.Controls.Add(this.RegisterNum);
            this.每日趨勢.Controls.Add(this.chart1);
            this.每日趨勢.Location = new System.Drawing.Point(4, 22);
            this.每日趨勢.Name = "每日趨勢";
            this.每日趨勢.Padding = new System.Windows.Forms.Padding(3);
            this.每日趨勢.Size = new System.Drawing.Size(784, 507);
            this.每日趨勢.TabIndex = 0;
            this.每日趨勢.Text = "每日趨勢";
            this.每日趨勢.UseVisualStyleBackColor = true;
            // 
            // TotalMoney
            // 
            this.TotalMoney.AutoSize = true;
            this.TotalMoney.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalMoney.Location = new System.Drawing.Point(669, 48);
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.Size = new System.Drawing.Size(48, 24);
            this.TotalMoney.TabIndex = 4;
            this.TotalMoney.Text = "總額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(539, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "今天總營收";
            // 
            // RegisterNum
            // 
            this.RegisterNum.AutoSize = true;
            this.RegisterNum.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RegisterNum.Location = new System.Drawing.Point(669, 17);
            this.RegisterNum.Name = "RegisterNum";
            this.RegisterNum.Size = new System.Drawing.Size(48, 24);
            this.RegisterNum.TabIndex = 2;
            this.RegisterNum.Text = "人數";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(539, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "今天註冊人數";
            // 
            // 男女分布
            // 
            this.男女分布.Controls.Add(this.chart2);
            this.男女分布.Location = new System.Drawing.Point(4, 22);
            this.男女分布.Name = "男女分布";
            this.男女分布.Padding = new System.Windows.Forms.Padding(3);
            this.男女分布.Size = new System.Drawing.Size(784, 507);
            this.男女分布.TabIndex = 1;
            this.男女分布.Text = "男女分布";
            this.男女分布.UseVisualStyleBackColor = true;
            // 
            // 地區分布
            // 
            this.地區分布.Controls.Add(this.chart3);
            this.地區分布.Location = new System.Drawing.Point(4, 22);
            this.地區分布.Name = "地區分布";
            this.地區分布.Padding = new System.Windows.Forms.Padding(3);
            this.地區分布.Size = new System.Drawing.Size(458, 286);
            this.地區分布.TabIndex = 2;
            this.地區分布.Text = "地區分布";
            this.地區分布.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(3, 3);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            series3.IsValueShownAsLabel = true;
            series3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series3.LabelBorderColor = System.Drawing.Color.Transparent;
            series3.LabelBorderWidth = 10;
            series3.LabelForeColor = System.Drawing.Color.SlateBlue;
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 5;
            series3.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series3.MarkerSize = 10;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series3.Name = "Series1";
            series3.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Lime;
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(452, 280);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series2.LabelForeColor = System.Drawing.Color.Gray;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(778, 501);
            this.chart2.TabIndex = 135;
            this.chart2.Text = "chart1";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(481, 507);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart2";
            // 
            // 統計
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "統計";
            this.Text = "統計";
            this.tabControl1.ResumeLayout(false);
            this.每日趨勢.ResumeLayout(false);
            this.每日趨勢.PerformLayout();
            this.男女分布.ResumeLayout(false);
            this.地區分布.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 每日趨勢;
        private System.Windows.Forms.Label TotalMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RegisterNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage 男女分布;
        private System.Windows.Forms.TabPage 地區分布;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}