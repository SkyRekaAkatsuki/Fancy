namespace UI_JA_Members
{
    partial class JA_Input
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Location = new System.Drawing.Point(3, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 2);
            this.panel3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Text";
            // 
            // Textbox_text
            // 
            this.Textbox_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_text.BackColor = System.Drawing.Color.White;
            this.Textbox_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_text.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_text.Location = new System.Drawing.Point(3, 15);
            this.Textbox_text.Name = "Textbox_text";
            this.Textbox_text.Size = new System.Drawing.Size(193, 18);
            this.Textbox_text.TabIndex = 23;
            this.Textbox_text.Enter += new System.EventHandler(this.Account_text_Enter);
            this.Textbox_text.Leave += new System.EventHandler(this.Account_text_Leave);
            // 
            // JA_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Textbox_text);
            this.Name = "JA_Input";
            this.Size = new System.Drawing.Size(201, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox_text;
    }
}
