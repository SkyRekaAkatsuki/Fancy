namespace Ctr_Customs
{
    partial class JA_OrderDetailList
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
            this.小計 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pname
            // 
            this.Pname.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pname.Location = new System.Drawing.Point(3, 7);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(198, 20);
            this.Pname.TabIndex = 0;
            this.Pname.Text = "label1";
            this.Pname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pcolor
            // 
            this.Pcolor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pcolor.Location = new System.Drawing.Point(251, 7);
            this.Pcolor.Name = "Pcolor";
            this.Pcolor.Size = new System.Drawing.Size(34, 20);
            this.Pcolor.TabIndex = 1;
            this.Pcolor.Text = "label2";
            this.Pcolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Psize
            // 
            this.Psize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Psize.Location = new System.Drawing.Point(365, 7);
            this.Psize.Name = "Psize";
            this.Psize.Size = new System.Drawing.Size(33, 20);
            this.Psize.TabIndex = 2;
            this.Psize.Text = "label3";
            this.Psize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // up
            // 
            this.up.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.up.Location = new System.Drawing.Point(493, 7);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(107, 20);
            this.up.TabIndex = 3;
            this.up.Text = "label4";
            this.up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QTY
            // 
            this.QTY.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.QTY.Location = new System.Drawing.Point(445, 7);
            this.QTY.Name = "QTY";
            this.QTY.Size = new System.Drawing.Size(35, 20);
            this.QTY.TabIndex = 4;
            this.QTY.Text = "label5";
            this.QTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 30);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(707, 10);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // 小計
            // 
            this.小計.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.小計.Location = new System.Drawing.Point(606, 7);
            this.小計.Name = "小計";
            this.小計.Size = new System.Drawing.Size(107, 20);
            this.小計.TabIndex = 6;
            this.小計.Text = "label4";
            this.小計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JA_OrderDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.小計);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.QTY);
            this.Controls.Add(this.up);
            this.Controls.Add(this.Psize);
            this.Controls.Add(this.Pcolor);
            this.Controls.Add(this.Pname);
            this.Name = "JA_OrderDetailList";
            this.Size = new System.Drawing.Size(715, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Pname;
        private System.Windows.Forms.Label Pcolor;
        private System.Windows.Forms.Label Psize;
        private System.Windows.Forms.Label up;
        private System.Windows.Forms.Label QTY;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label 小計;
    }
}
