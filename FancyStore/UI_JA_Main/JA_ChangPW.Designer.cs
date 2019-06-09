namespace UI_JA_Main
{
    partial class JA_ChangPW
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
            this.label1 = new System.Windows.Forms.Label();
            this.驗證碼_P = new System.Windows.Forms.Panel();
            this.驗證碼_B = new System.Windows.Forms.Button();
            this.jA_Input4 = new UI_JA_Members.JA_Input();
            this.新密碼_P = new System.Windows.Forms.Panel();
            this.jA_Input3 = new UI_JA_Members.JA_Input();
            this.新密碼_B = new System.Windows.Forms.Button();
            this.驗證舊密碼_P = new System.Windows.Forms.Panel();
            this.jA_Input2 = new UI_JA_Members.JA_Input();
            this.jA_Input1 = new UI_JA_Members.JA_Input();
            this.B_更改密碼 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.驗證碼_P.SuspendLayout();
            this.新密碼_P.SuspendLayout();
            this.驗證舊密碼_P.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(82, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Loading";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // 驗證碼_P
            // 
            this.驗證碼_P.Controls.Add(this.驗證碼_B);
            this.驗證碼_P.Controls.Add(this.jA_Input4);
            this.驗證碼_P.Location = new System.Drawing.Point(84, 420);
            this.驗證碼_P.Name = "驗證碼_P";
            this.驗證碼_P.Size = new System.Drawing.Size(200, 100);
            this.驗證碼_P.TabIndex = 16;
            this.驗證碼_P.Visible = false;
            // 
            // 驗證碼_B
            // 
            this.驗證碼_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            this.驗證碼_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.驗證碼_B.Location = new System.Drawing.Point(57, 73);
            this.驗證碼_B.Name = "驗證碼_B";
            this.驗證碼_B.Size = new System.Drawing.Size(75, 23);
            this.驗證碼_B.TabIndex = 5;
            this.驗證碼_B.Text = "確認驗證碼";
            this.驗證碼_B.UseVisualStyleBackColor = false;
            this.驗證碼_B.Click += new System.EventHandler(this.驗證碼_B_Click);
            // 
            // jA_Input4
            // 
            this.jA_Input4.BackColor = System.Drawing.Color.Transparent;
            this.jA_Input4.Location = new System.Drawing.Point(0, 18);
            this.jA_Input4.Name = "jA_Input4";
            this.jA_Input4.Size = new System.Drawing.Size(200, 49);
            this.jA_Input4.TabIndex = 7;
            this.jA_Input4.Text = "驗證碼";
            this.jA_Input4.輸入塊字串 = "";
            // 
            // 新密碼_P
            // 
            this.新密碼_P.Controls.Add(this.jA_Input3);
            this.新密碼_P.Controls.Add(this.新密碼_B);
            this.新密碼_P.Location = new System.Drawing.Point(84, 420);
            this.新密碼_P.Name = "新密碼_P";
            this.新密碼_P.Size = new System.Drawing.Size(200, 100);
            this.新密碼_P.TabIndex = 15;
            this.新密碼_P.Visible = false;
            // 
            // jA_Input3
            // 
            this.jA_Input3.BackColor = System.Drawing.Color.Transparent;
            this.jA_Input3.Location = new System.Drawing.Point(0, 18);
            this.jA_Input3.Name = "jA_Input3";
            this.jA_Input3.Size = new System.Drawing.Size(200, 49);
            this.jA_Input3.TabIndex = 6;
            this.jA_Input3.Text = "新密碼";
            this.jA_Input3.輸入塊字串 = "";
            // 
            // 新密碼_B
            // 
            this.新密碼_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            this.新密碼_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.新密碼_B.Location = new System.Drawing.Point(57, 73);
            this.新密碼_B.Name = "新密碼_B";
            this.新密碼_B.Size = new System.Drawing.Size(75, 23);
            this.新密碼_B.TabIndex = 6;
            this.新密碼_B.Text = "下一步";
            this.新密碼_B.UseVisualStyleBackColor = false;
            this.新密碼_B.Click += new System.EventHandler(this.新密碼_B_Click);
            // 
            // 驗證舊密碼_P
            // 
            this.驗證舊密碼_P.Controls.Add(this.jA_Input2);
            this.驗證舊密碼_P.Controls.Add(this.jA_Input1);
            this.驗證舊密碼_P.Controls.Add(this.B_更改密碼);
            this.驗證舊密碼_P.Location = new System.Drawing.Point(84, 55);
            this.驗證舊密碼_P.Name = "驗證舊密碼_P";
            this.驗證舊密碼_P.Size = new System.Drawing.Size(200, 159);
            this.驗證舊密碼_P.TabIndex = 14;
            // 
            // jA_Input2
            // 
            this.jA_Input2.BackColor = System.Drawing.Color.Transparent;
            this.jA_Input2.Location = new System.Drawing.Point(-1, 67);
            this.jA_Input2.Name = "jA_Input2";
            this.jA_Input2.Size = new System.Drawing.Size(201, 49);
            this.jA_Input2.TabIndex = 19;
            this.jA_Input2.Text = "舊密碼";
            this.jA_Input2.輸入塊字串 = "";
            // 
            // jA_Input1
            // 
            this.jA_Input1.BackColor = System.Drawing.Color.Transparent;
            this.jA_Input1.Location = new System.Drawing.Point(0, 12);
            this.jA_Input1.Name = "jA_Input1";
            this.jA_Input1.Size = new System.Drawing.Size(199, 49);
            this.jA_Input1.TabIndex = 18;
            this.jA_Input1.Text = "帳號";
            this.jA_Input1.輸入塊字串 = "";
            // 
            // B_更改密碼
            // 
            this.B_更改密碼.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            this.B_更改密碼.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_更改密碼.Location = new System.Drawing.Point(56, 122);
            this.B_更改密碼.Name = "B_更改密碼";
            this.B_更改密碼.Size = new System.Drawing.Size(75, 23);
            this.B_更改密碼.TabIndex = 4;
            this.B_更改密碼.Text = "下一步";
            this.B_更改密碼.UseVisualStyleBackColor = false;
            this.B_更改密碼.Click += new System.EventHandler(this.B_更改密碼_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 35);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "更改密碼";
            // 
            // JA_ChangPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 244);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.新密碼_P);
            this.Controls.Add(this.驗證舊密碼_P);
            this.Controls.Add(this.驗證碼_P);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JA_ChangPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密碼更改";
            this.驗證碼_P.ResumeLayout(false);
            this.新密碼_P.ResumeLayout(false);
            this.驗證舊密碼_P.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel 驗證碼_P;
        private UI_JA_Members.JA_Input jA_Input4;
        private System.Windows.Forms.Button 驗證碼_B;
        private System.Windows.Forms.Panel 新密碼_P;
        private UI_JA_Members.JA_Input jA_Input3;
        private System.Windows.Forms.Button 新密碼_B;
        private System.Windows.Forms.Panel 驗證舊密碼_P;
        private UI_JA_Members.JA_Input jA_Input2;
        private UI_JA_Members.JA_Input jA_Input1;
        private System.Windows.Forms.Button B_更改密碼;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}