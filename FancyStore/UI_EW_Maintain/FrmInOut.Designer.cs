namespace UI_EW_Maintain
{
    partial class FrmInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInOut));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbCearSearch = new System.Windows.Forms.ToolStripButton();
            this.vWEWCategorySMLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWEWCategorySMLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vWEWSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInDateDataGridViewTextBoxColumn = new Cls_Utility.CalendarColumn();
            this.productOutDateDataGridViewTextBoxColumn = new Cls_Utility.CalendarColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.desctiptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorySIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorySmallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myFavoritesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productEvaluationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productColorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPhotoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSizesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStocksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productWashingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEWCategorySMLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEWCategorySMLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEWSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "～";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(409, 36);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 25);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 25);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "日期區間";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFind.Location = new System.Drawing.Point(927, 33);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(140, 64);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "查詢";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DataSource = this.vWEWCategorySMLBindingSource;
            this.cbCategory.DisplayMember = "CategoryName";
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(409, 71);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(468, 23);
            this.cbCategory.TabIndex = 23;
            this.cbCategory.ValueMember = "CategorySID";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(90, 71);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(264, 25);
            this.txtProductName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "分類";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "產品名稱";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DB_Fancy.Product);
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem,
            this.toolStripLabel1,
            this.tsbCearSearch});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(1182, 27);
            this.productBindingNavigator.TabIndex = 29;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Enabled = false;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.productBindingNavigatorSaveItem.Text = "儲存資料";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.btnSave,
            this.productNameDataGridViewTextBoxColumn,
            this.productInDateDataGridViewTextBoxColumn,
            this.productOutDateDataGridViewTextBoxColumn,
            this.CategoryName,
            this.SupplierName,
            this.desctiptionDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.categorySIDDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.categorySmallDataGridViewTextBoxColumn,
            this.myFavoritesDataGridViewTextBoxColumn,
            this.orderDetailsDataGridViewTextBoxColumn,
            this.productEvaluationsDataGridViewTextBoxColumn,
            this.productColorsDataGridViewTextBoxColumn,
            this.productPhotoesDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.productSizesDataGridViewTextBoxColumn,
            this.productStocksDataGridViewTextBoxColumn,
            this.productWashingsDataGridViewTextBoxColumn});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(12, 106);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowTemplate.Height = 27;
            this.productDataGridView.Size = new System.Drawing.Size(1140, 537);
            this.productDataGridView.TabIndex = 29;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 24);
            // 
            // tsbCearSearch
            // 
            this.tsbCearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tsbCearSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCearSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbCearSearch.Image")));
            this.tsbCearSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCearSearch.Name = "tsbCearSearch";
            this.tsbCearSearch.Size = new System.Drawing.Size(103, 24);
            this.tsbCearSearch.Text = "清空查詢資料";
            this.tsbCearSearch.Click += new System.EventHandler(this.tsbCearSearch_Click);
            // 
            // vWEWCategorySMLBindingSource
            // 
            this.vWEWCategorySMLBindingSource.DataSource = typeof(DB_Fancy.VW_EW_CategorySML);
            // 
            // vWEWCategorySMLBindingSource1
            // 
            this.vWEWCategorySMLBindingSource1.DataSource = typeof(DB_Fancy.VW_EW_CategorySML);
            // 
            // vWEWSupplierBindingSource
            // 
            this.vWEWSupplierBindingSource.DataSource = typeof(DB_Fancy.VW_EW_Supplier);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // btnSave
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnSave.HeaderText = "Save";
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "存檔";
            this.btnSave.UseColumnTextForButtonValue = true;
            this.btnSave.Width = 80;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "產品名稱";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productInDateDataGridViewTextBoxColumn
            // 
            this.productInDateDataGridViewTextBoxColumn.DataPropertyName = "ProductInDate";
            this.productInDateDataGridViewTextBoxColumn.HeaderText = "上架日期";
            this.productInDateDataGridViewTextBoxColumn.Name = "productInDateDataGridViewTextBoxColumn";
            this.productInDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productInDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // productOutDateDataGridViewTextBoxColumn
            // 
            this.productOutDateDataGridViewTextBoxColumn.DataPropertyName = "ProductOutDate";
            this.productOutDateDataGridViewTextBoxColumn.HeaderText = "下架日期";
            this.productOutDateDataGridViewTextBoxColumn.Name = "productOutDateDataGridViewTextBoxColumn";
            this.productOutDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productOutDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategorySID";
            this.CategoryName.DataSource = this.vWEWCategorySMLBindingSource1;
            this.CategoryName.DisplayMember = "CategoryName";
            this.CategoryName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CategoryName.HeaderText = "分類";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.ValueMember = "CategorySID";
            this.CategoryName.Width = 200;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierID";
            this.SupplierName.DataSource = this.vWEWSupplierBindingSource;
            this.SupplierName.DisplayMember = "SupplierName";
            this.SupplierName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.SupplierName.HeaderText = "供應商";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.ValueMember = "SupplierID";
            // 
            // desctiptionDataGridViewTextBoxColumn
            // 
            this.desctiptionDataGridViewTextBoxColumn.DataPropertyName = "Desctiption";
            this.desctiptionDataGridViewTextBoxColumn.HeaderText = "詳細規格描述";
            this.desctiptionDataGridViewTextBoxColumn.Name = "desctiptionDataGridViewTextBoxColumn";
            this.desctiptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.desctiptionDataGridViewTextBoxColumn.Visible = false;
            this.desctiptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // categorySIDDataGridViewTextBoxColumn
            // 
            this.categorySIDDataGridViewTextBoxColumn.DataPropertyName = "CategorySID";
            this.categorySIDDataGridViewTextBoxColumn.HeaderText = "CategorySID";
            this.categorySIDDataGridViewTextBoxColumn.Name = "categorySIDDataGridViewTextBoxColumn";
            this.categorySIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // categorySmallDataGridViewTextBoxColumn
            // 
            this.categorySmallDataGridViewTextBoxColumn.DataPropertyName = "CategorySmall";
            this.categorySmallDataGridViewTextBoxColumn.HeaderText = "CategorySmall";
            this.categorySmallDataGridViewTextBoxColumn.Name = "categorySmallDataGridViewTextBoxColumn";
            this.categorySmallDataGridViewTextBoxColumn.Visible = false;
            // 
            // myFavoritesDataGridViewTextBoxColumn
            // 
            this.myFavoritesDataGridViewTextBoxColumn.DataPropertyName = "MyFavorites";
            this.myFavoritesDataGridViewTextBoxColumn.HeaderText = "MyFavorites";
            this.myFavoritesDataGridViewTextBoxColumn.Name = "myFavoritesDataGridViewTextBoxColumn";
            this.myFavoritesDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderDetailsDataGridViewTextBoxColumn
            // 
            this.orderDetailsDataGridViewTextBoxColumn.DataPropertyName = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.HeaderText = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.Name = "orderDetailsDataGridViewTextBoxColumn";
            this.orderDetailsDataGridViewTextBoxColumn.Visible = false;
            // 
            // productEvaluationsDataGridViewTextBoxColumn
            // 
            this.productEvaluationsDataGridViewTextBoxColumn.DataPropertyName = "ProductEvaluations";
            this.productEvaluationsDataGridViewTextBoxColumn.HeaderText = "ProductEvaluations";
            this.productEvaluationsDataGridViewTextBoxColumn.Name = "productEvaluationsDataGridViewTextBoxColumn";
            this.productEvaluationsDataGridViewTextBoxColumn.Visible = false;
            // 
            // productColorsDataGridViewTextBoxColumn
            // 
            this.productColorsDataGridViewTextBoxColumn.DataPropertyName = "ProductColors";
            this.productColorsDataGridViewTextBoxColumn.HeaderText = "ProductColors";
            this.productColorsDataGridViewTextBoxColumn.Name = "productColorsDataGridViewTextBoxColumn";
            this.productColorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // productPhotoesDataGridViewTextBoxColumn
            // 
            this.productPhotoesDataGridViewTextBoxColumn.DataPropertyName = "ProductPhotoes";
            this.productPhotoesDataGridViewTextBoxColumn.HeaderText = "ProductPhotoes";
            this.productPhotoesDataGridViewTextBoxColumn.Name = "productPhotoesDataGridViewTextBoxColumn";
            this.productPhotoesDataGridViewTextBoxColumn.Visible = false;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.Visible = false;
            // 
            // productSizesDataGridViewTextBoxColumn
            // 
            this.productSizesDataGridViewTextBoxColumn.DataPropertyName = "ProductSizes";
            this.productSizesDataGridViewTextBoxColumn.HeaderText = "ProductSizes";
            this.productSizesDataGridViewTextBoxColumn.Name = "productSizesDataGridViewTextBoxColumn";
            this.productSizesDataGridViewTextBoxColumn.Visible = false;
            // 
            // productStocksDataGridViewTextBoxColumn
            // 
            this.productStocksDataGridViewTextBoxColumn.DataPropertyName = "ProductStocks";
            this.productStocksDataGridViewTextBoxColumn.HeaderText = "ProductStocks";
            this.productStocksDataGridViewTextBoxColumn.Name = "productStocksDataGridViewTextBoxColumn";
            this.productStocksDataGridViewTextBoxColumn.Visible = false;
            // 
            // productWashingsDataGridViewTextBoxColumn
            // 
            this.productWashingsDataGridViewTextBoxColumn.DataPropertyName = "ProductWashings";
            this.productWashingsDataGridViewTextBoxColumn.HeaderText = "ProductWashings";
            this.productWashingsDataGridViewTextBoxColumn.Name = "productWashingsDataGridViewTextBoxColumn";
            this.productWashingsDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productBindingNavigator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "產品上下架 - FrmInOut";
            this.Load += new System.EventHandler(this.FrmInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEWCategorySMLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEWCategorySMLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEWSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbCearSearch;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource vWEWCategorySMLBindingSource;
        private System.Windows.Forms.BindingSource vWEWCategorySMLBindingSource1;
        private System.Windows.Forms.BindingSource vWEWSupplierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private Cls_Utility.CalendarColumn productInDateDataGridViewTextBoxColumn;
        private Cls_Utility.CalendarColumn productOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewComboBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn desctiptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorySIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorySmallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn myFavoritesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productEvaluationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productColorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPhotoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSizesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStocksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productWashingsDataGridViewTextBoxColumn;
    }
}