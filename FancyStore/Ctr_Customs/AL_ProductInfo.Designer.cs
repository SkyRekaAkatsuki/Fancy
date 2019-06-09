namespace Ctr_Customs
{
    partial class AL_ProductInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AL_ProductInfo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Price = new System.Windows.Forms.Label();
            this.Pb_Productimage = new System.Windows.Forms.PictureBox();
            this.Btn_Favorite = new System.Windows.Forms.Button();
            this.Pb_Cartstatus = new System.Windows.Forms.PictureBox();
            this.P_Buttom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Productimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Cartstatus)).BeginInit();
            this.P_Buttom.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_heart34_216489.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_heart13_216262.png");
            this.imageList1.Images.SetKeyName(2, "iconfinder_finance-01_808648.png");
            this.imageList1.Images.SetKeyName(3, "iconfinder_finance-02_808677.png");
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Name.Location = new System.Drawing.Point(5, 270);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(231, 62);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "PName";
            // 
            // Lbl_Price
            // 
            this.Lbl_Price.AutoSize = true;
            this.Lbl_Price.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Price.Location = new System.Drawing.Point(5, 311);
            this.Lbl_Price.Name = "Lbl_Price";
            this.Lbl_Price.Size = new System.Drawing.Size(58, 19);
            this.Lbl_Price.TabIndex = 1;
            this.Lbl_Price.Text = "PPRice";
            // 
            // Pb_Productimage
            // 
            this.Pb_Productimage.BackColor = System.Drawing.Color.Black;
            this.Pb_Productimage.Location = new System.Drawing.Point(3, 2);
            this.Pb_Productimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_Productimage.Name = "Pb_Productimage";
            this.Pb_Productimage.Size = new System.Drawing.Size(235, 260);
            this.Pb_Productimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Productimage.TabIndex = 2;
            this.Pb_Productimage.TabStop = false;
            // 
            // Btn_Favorite
            // 
            this.Btn_Favorite.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Favorite.FlatAppearance.BorderSize = 0;
            this.Btn_Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Favorite.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Favorite.Location = new System.Drawing.Point(197, 2);
            this.Btn_Favorite.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Favorite.Name = "Btn_Favorite";
            this.Btn_Favorite.Size = new System.Drawing.Size(40, 40);
            this.Btn_Favorite.TabIndex = 3;
            this.Btn_Favorite.UseVisualStyleBackColor = false;
            this.Btn_Favorite.Click += new System.EventHandler(this.Btn_Favorite_Click);
            // 
            // Pb_Cartstatus
            // 
            this.Pb_Cartstatus.BackColor = System.Drawing.Color.Gold;
            this.Pb_Cartstatus.Location = new System.Drawing.Point(197, 42);
            this.Pb_Cartstatus.Margin = new System.Windows.Forms.Padding(0);
            this.Pb_Cartstatus.Name = "Pb_Cartstatus";
            this.Pb_Cartstatus.Size = new System.Drawing.Size(40, 40);
            this.Pb_Cartstatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_Cartstatus.TabIndex = 4;
            this.Pb_Cartstatus.TabStop = false;
            // 
            // P_Buttom
            // 
            this.P_Buttom.BackColor = System.Drawing.Color.White;
            this.P_Buttom.Controls.Add(this.Pb_Cartstatus);
            this.P_Buttom.Controls.Add(this.Btn_Favorite);
            this.P_Buttom.Controls.Add(this.Pb_Productimage);
            this.P_Buttom.Controls.Add(this.Lbl_Price);
            this.P_Buttom.Controls.Add(this.Lbl_Name);
            this.P_Buttom.Location = new System.Drawing.Point(5, 5);
            this.P_Buttom.Margin = new System.Windows.Forms.Padding(0);
            this.P_Buttom.Name = "P_Buttom";
            this.P_Buttom.Size = new System.Drawing.Size(241, 340);
            this.P_Buttom.TabIndex = 0;
            this.P_Buttom.Click += new System.EventHandler(this.C_Click);
            this.P_Buttom.MouseEnter += new System.EventHandler(this.AL_ProductInfo_MouseEnter);
            this.P_Buttom.MouseLeave += new System.EventHandler(this.AL_ProductInfo_MouseLeave);
            // 
            // AL_ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.P_Buttom);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AL_ProductInfo";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(251, 350);
            this.Load += new System.EventHandler(this.AL_ProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Productimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Cartstatus)).EndInit();
            this.P_Buttom.ResumeLayout(false);
            this.P_Buttom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Price;
        private System.Windows.Forms.PictureBox Pb_Productimage;
        private System.Windows.Forms.Button Btn_Favorite;
        private System.Windows.Forms.PictureBox Pb_Cartstatus;
        private System.Windows.Forms.Panel P_Buttom;
    }
}
