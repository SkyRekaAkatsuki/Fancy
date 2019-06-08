namespace UI_EW_Maintain
{
    partial class FrmProductMaintain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.btnWashing = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnColot = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbCategoryS = new System.Windows.Forms.ComboBox();
            this.vWEWCategorySMLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.vWEWSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWEWCategorySMLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEWSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnPhoto);
            this.groupBox1.Controls.Add(this.btnWashing);
            this.groupBox1.Controls.Add(this.btnStock);
            this.groupBox1.Controls.Add(this.btnSize);
            this.groupBox1.Controls.Add(this.btnColot);
            this.groupBox1.Location = new System.Drawing.Point(551, 262);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(325, 379);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "其他資料維護";
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPhoto.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPhoto.Location = new System.Drawing.Point(71, 38);
            this.btnPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(192, 55);
            this.btnPhoto.TabIndex = 4;
            this.btnPhoto.Text = "產品圖片";
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // btnWashing
            // 
            this.btnWashing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWashing.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWashing.Location = new System.Drawing.Point(71, 102);
            this.btnWashing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWashing.Name = "btnWashing";
            this.btnWashing.Size = new System.Drawing.Size(192, 55);
            this.btnWashing.TabIndex = 3;
            this.btnWashing.Text = "洗滌方式";
            this.btnWashing.UseVisualStyleBackColor = false;
            this.btnWashing.Click += new System.EventHandler(this.btnWashing_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStock.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStock.Location = new System.Drawing.Point(71, 289);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(192, 58);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "庫存量";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnSize
            // 
            this.btnSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSize.Location = new System.Drawing.Point(71, 168);
            this.btnSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(192, 51);
            this.btnSize.TabIndex = 1;
            this.btnSize.Text = "尺吋大小";
            this.btnSize.UseVisualStyleBackColor = false;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnColot
            // 
            this.btnColot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnColot.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnColot.Location = new System.Drawing.Point(71, 229);
            this.btnColot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColot.Name = "btnColot";
            this.btnColot.Size = new System.Drawing.Size(192, 50);
            this.btnColot.TabIndex = 0;
            this.btnColot.Text = "顏色";
            this.btnColot.UseVisualStyleBackColor = false;
            this.btnColot.Click += new System.EventHandler(this.btnColot_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus.Location = new System.Drawing.Point(603, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 25);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "狀態 : ";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(148, 22);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(97, 25);
            this.txtProductID.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "產品ID";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(201, 508);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(189, 79);
            this.btnInsert.TabIndex = 31;
            this.btnInsert.Text = "存檔";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cbCategoryS
            // 
            this.cbCategoryS.DataSource = this.vWEWCategorySMLBindingSource;
            this.cbCategoryS.DisplayMember = "CategoryName";
            this.cbCategoryS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryS.FormattingEnabled = true;
            this.cbCategoryS.Location = new System.Drawing.Point(148, 258);
            this.cbCategoryS.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoryS.Name = "cbCategoryS";
            this.cbCategoryS.Size = new System.Drawing.Size(360, 23);
            this.cbCategoryS.TabIndex = 30;
            this.cbCategoryS.ValueMember = "CategorySID";
            // 
            // vWEWCategorySMLBindingSource
            // 
            this.vWEWCategorySMLBindingSource.DataSource = typeof(DB_Fancy.VW_EW_CategorySML);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 444);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(241, 25);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 404);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 25);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(148, 351);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(189, 25);
            this.txtUnitPrice.TabIndex = 27;
            this.txtUnitPrice.Text = "500";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(148, 102);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(528, 135);
            this.txtDescription.TabIndex = 26;
            this.txtDescription.Text = "T恤-短袖-白色";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(148, 62);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(312, 25);
            this.txtProductName.TabIndex = 25;
            this.txtProductName.Text = "T恤";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 451);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "下架日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "單價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "小分類";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 409);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "上架日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "產品詳細說明";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "產品名稱";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DataSource = this.vWEWSupplierBindingSource;
            this.cbSupplier.DisplayMember = "SupplierName";
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(148, 301);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(360, 23);
            this.cbSupplier.TabIndex = 37;
            this.cbSupplier.ValueMember = "SupplierID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 305);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "供應商";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // vWEWSupplierBindingSource
            // 
            this.vWEWSupplierBindingSource.DataSource = typeof(DB_Fancy.VW_EW_Supplier);
            // 
            // FrmProductMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 652);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbCategoryS);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProductMaintain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "產品資料維護 - FrmProductMaintain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProductMaintain_FormClosing);
            this.Load += new System.EventHandler(this.FrmProductMaintain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vWEWCategorySMLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEWSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWashing;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnColot;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cbCategoryS;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource vWEWCategorySMLBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.BindingSource vWEWSupplierBindingSource;
    }
}