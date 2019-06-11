namespace UI_SK_ShoppingCart
{
    partial class UI_SK_MotherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_SK_MotherForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyMini = new System.Windows.Forms.Button();
            this.MyClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(124)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.MyMini);
            this.panel1.Controls.Add(this.MyClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 45);
            this.panel1.TabIndex = 1;
            // 
            // MyMini
            // 
            this.MyMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyMini.FlatAppearance.BorderSize = 0;
            this.MyMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyMini.Image = ((System.Drawing.Image)(resources.GetObject("MyMini.Image")));
            this.MyMini.Location = new System.Drawing.Point(850, 0);
            this.MyMini.Margin = new System.Windows.Forms.Padding(4);
            this.MyMini.Name = "MyMini";
            this.MyMini.Size = new System.Drawing.Size(52, 45);
            this.MyMini.TabIndex = 0;
            this.MyMini.UseVisualStyleBackColor = true;
            this.MyMini.Click += new System.EventHandler(this.MyMini_Click);
            // 
            // MyClose
            // 
            this.MyClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyClose.FlatAppearance.BorderSize = 0;
            this.MyClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyClose.Image = ((System.Drawing.Image)(resources.GetObject("MyClose.Image")));
            this.MyClose.Location = new System.Drawing.Point(898, 0);
            this.MyClose.Margin = new System.Windows.Forms.Padding(4);
            this.MyClose.Name = "MyClose";
            this.MyClose.Size = new System.Drawing.Size(52, 45);
            this.MyClose.TabIndex = 0;
            this.MyClose.UseVisualStyleBackColor = true;
            this.MyClose.Click += new System.EventHandler(this.MyClose_Click);
            // 
            // UI_SK_MotherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(950, 1000);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI_SK_MotherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI_SK_MainCart";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MyMini;
        private System.Windows.Forms.Button MyClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}