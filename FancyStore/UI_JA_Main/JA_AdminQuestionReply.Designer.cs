namespace UI_JA_Main
{
    partial class JA_AdminQuestionReply
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.jA_AdminReplayLeft1 = new Ctr_Customs.JA_AdminReplayLeft();
            this.jA_AdminReplayLeft2 = new Ctr_Customs.JA_AdminReplayLeft();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            this.flowLayoutPanel1.Controls.Add(this.jA_AdminReplayLeft1);
            this.flowLayoutPanel1.Controls.Add(this.jA_AdminReplayLeft2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 404);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // jA_AdminReplayLeft1
            // 
            this.jA_AdminReplayLeft1.AutoSize = true;
            this.jA_AdminReplayLeft1.Location = new System.Drawing.Point(0, 3);
            this.jA_AdminReplayLeft1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.jA_AdminReplayLeft1.Name = "jA_AdminReplayLeft1";
            this.jA_AdminReplayLeft1.Size = new System.Drawing.Size(0, 0);
            this.jA_AdminReplayLeft1.TabIndex = 0;
            // 
            // jA_AdminReplayLeft2
            // 
            this.jA_AdminReplayLeft2.AutoSize = true;
            this.jA_AdminReplayLeft2.Location = new System.Drawing.Point(0, 3);
            this.jA_AdminReplayLeft2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.jA_AdminReplayLeft2.Name = "jA_AdminReplayLeft2";
            this.jA_AdminReplayLeft2.Size = new System.Drawing.Size(0, 0);
            this.jA_AdminReplayLeft2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(130, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 404);
            this.panel2.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 38);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "留言管理";
            // 
            // AdminQuestionReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminQuestionReply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "留言回覆功能";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Ctr_Customs.JA_AdminReplayLeft jA_AdminReplayLeft1;
        private Ctr_Customs.JA_AdminReplayLeft jA_AdminReplayLeft2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}