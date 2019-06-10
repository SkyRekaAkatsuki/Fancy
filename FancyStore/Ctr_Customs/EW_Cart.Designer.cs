namespace Ctr_Customs
{
    partial class EW_Cart
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
            this.lblSubAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.nuQty = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStockQTY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubAmount
            // 
            this.lblSubAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSubAmount.Location = new System.Drawing.Point(767, 0);
            this.lblSubAmount.Name = "lblSubAmount";
            this.lblSubAmount.Size = new System.Drawing.Size(108, 36);
            this.lblSubAmount.TabIndex = 25;
            this.lblSubAmount.Text = "小計金額";
            this.lblSubAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUnitPrice.Location = new System.Drawing.Point(500, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(81, 36);
            this.lblUnitPrice.TabIndex = 23;
            this.lblUnitPrice.Text = "單價";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSize
            // 
            this.lblSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSize.Location = new System.Drawing.Point(443, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(51, 36);
            this.lblSize.TabIndex = 22;
            this.lblSize.Text = "尺吋";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblColor.Location = new System.Drawing.Point(363, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(75, 36);
            this.lblColor.TabIndex = 21;
            this.lblColor.Text = "顏色";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblProductName.Location = new System.Drawing.Point(3, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(353, 36);
            this.lblProductName.TabIndex = 20;
            this.lblProductName.Text = "產品名稱";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nuQty
            // 
            this.nuQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nuQty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nuQty.Location = new System.Drawing.Point(588, 0);
            this.nuQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nuQty.Name = "nuQty";
            this.nuQty.Size = new System.Drawing.Size(80, 34);
            this.nuQty.TabIndex = 26;
            this.nuQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nuQty.ValueChanged += new System.EventHandler(this.nuQty_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(881, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 36);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStockQTY
            // 
            this.lblStockQTY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStockQTY.Location = new System.Drawing.Point(675, 0);
            this.lblStockQTY.Name = "lblStockQTY";
            this.lblStockQTY.Size = new System.Drawing.Size(85, 36);
            this.lblStockQTY.TabIndex = 28;
            this.lblStockQTY.Text = "庫存量";
            this.lblStockQTY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EW_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStockQTY);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nuQty);
            this.Controls.Add(this.lblSubAmount);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblProductName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EW_Cart";
            this.Size = new System.Drawing.Size(984, 36);
            this.Load += new System.EventHandler(this.EW_Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSubAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.NumericUpDown nuQty;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStockQTY;
    }
}
