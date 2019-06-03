using DB_Fancy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_EW_Maintain
{
    public partial class FrmCategoryM : Form
    {
        public FrmCategoryM()
        {
            InitializeComponent();
        }

        private void FrmCategoryM_Load(object sender, EventArgs e)
        {
            this.categoryLargeBindingSource.DataSource = dbContext.CategoryLarges.ToList();
            this.categoryLargeDataGridView.DataSource = categoryLargeBindingSource;

            //ResetData();
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        CategoryLarge cl = new CategoryLarge();

        void ResetData(int catL)
        {
            this.categoryMiddleBindingSource.DataSource = dbContext.CategoryMiddles.Where(x=>x.CategoryLID == catL ).ToList();
            this.categoryMiddleDataGridView.DataSource = categoryMiddleBindingSource;
        }

        //讀取大分類目前所在位置的值
        private void categoryLargeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            cl.CategoryLID = ((CategoryLarge)categoryLargeBindingSource.Current).CategoryLID;
            cl.CategoryLName = ((CategoryLarge)categoryLargeBindingSource.Current).CategoryLName;

            ResetData(cl.CategoryLID);
        }

        private void categoryMiddleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryMiddle cm = new CategoryMiddle();
            int currentIdx = categoryMiddleBindingSource.Position;
            cm.CategoryMID = ((CategoryMiddle)categoryMiddleBindingSource.Current).CategoryMID;

            switch (e.ColumnIndex)
            {
                case 1:  //存檔
                    try
                    {
                        cm.CategoryMName = ((CategoryMiddle)categoryMiddleBindingSource.Current).CategoryMName;
                        cm.CategoryLID = cl.CategoryLID;

                        //新增
                        if (cm.CategoryMID == 0)
                        {
                            dbContext.CategoryMiddles.Add(cm);
                        }
                        else  //修改
                        {
                            var q = dbContext.CategoryMiddles.Find(cm.CategoryMID);
                            q.CategoryMName = cm.CategoryMName;
                        }

                        this.dbContext.SaveChanges();
                        ResetData(cl.CategoryLID);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    break;
                case 3: //刪除
                    if (cm.CategoryMID == 0)
                    {
                        MessageBox.Show("尚未存檔, 無法刪除 !");
                        return;
                    }

                    DialogResult result = MessageBox.Show("確定刪除 ?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) { return; }

                    try
                    {
                        var q = dbContext.CategoryMiddles.Find(cm.CategoryMID);

                        dbContext.CategoryMiddles.Remove(q);
                        this.dbContext.SaveChanges();
                        ResetData(cl.CategoryLID);
                    }
                    catch (Exception ex)
                    { Debug.WriteLine(ex); }
                    break;
            }
        }
    }
}
