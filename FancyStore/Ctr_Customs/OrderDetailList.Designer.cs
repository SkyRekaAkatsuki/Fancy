namespace Ctr_Customs
{
    partial class OrderDetailList
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Pname = new System.Windows.Forms.Label();
            this.Pcolor = new System.Windows.Forms.Label();
            this.Psize = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Label();
            this.QTY = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SuspendLayout();
            // 
            // Pname
            // 
            this.Pname.AutoSize = true;
            this.Pname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pname.Location = new System.Drawing.Point(37, 7);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(54, 20);
            this.Pname.TabIndex = 0;
            this.Pname.Text = "label1";
            // 
            // Pcolor
            // 
            this.Pcolor.AutoSize = true;
            this.Pcolor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pcolor.Location = new System.Drawing.Point(157, 7);
            this.Pcolor.Name = "Pcolor";
            this.Pcolor.Size = new System.Drawing.Size(54, 20);
            this.Pcolor.TabIndex = 1;
            this.Pcolor.Text = "label2";
            // 
            // Psize
            // 
            this.Psize.AutoSize = true;
            this.Psize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Psize.Location = new System.Drawing.Point(277, 7);
            this.Psize.Name = "Psize";
            this.Psize.Size = new System.Drawing.Size(54, 20);
            this.Psize.TabIndex = 2;
            this.Psize.Text = "label3";
            // 
            // up
            // 
            this.up.AutoSize = true;
            this.up.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.up.Location = new System.Drawing.Point(517, 7);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(54, 20);
            this.up.TabIndex = 3;
            this.up.Text = "label4";
            // 
            // QTY
            // 
            this.QTY.AutoSize = true;
            this.QTY.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.QTY.Location = new System.Drawing.Point(397, 7);
            this.QTY.Name = "QTY";
            this.QTY.Size = new System.Drawing.Size(54, 20);
            this.QTY.TabIndex = 4;
            this.QTY.Text = "label5";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 30);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(610, 10);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // OrderDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.QTY);
            this.Controls.Add(this.up);
            this.Controls.Add(this.Psize);
            this.Controls.Add(this.Pcolor);
            this.Controls.Add(this.Pname);
            this.Name = "OrderDetailList";
            this.Size = new System.Drawing.Size(610, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pname;
        private System.Windows.Forms.Label Pcolor;
        private System.Windows.Forms.Label Psize;
        private System.Windows.Forms.Label up;
        private System.Windows.Forms.Label QTY;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
