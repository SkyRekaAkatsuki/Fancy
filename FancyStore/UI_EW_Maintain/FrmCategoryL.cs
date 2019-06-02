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
    public partial class FrmCategoryL : Form
    {
        public FrmCategoryL()
        {
            InitializeComponent();
        }

        private void FrmCategoryL_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();

        void ResetData()
        {
            this.categoryLargeBindingSource.DataSource = dbContext.CategoryLarges.ToList();
            this.categoryLargeDataGridView.DataSource = categoryLargeBindingSource;
        }

        internal static class categoryL
        {
            internal static int categoryID { get; set; }
            internal static string categoryLName { get; set; }
        }

        private void categoryLargeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //categoryL.categoryID = ((CategoryLarge)categoryLargeBindingSource.Current).CategoryLID;
        }

        private void categoryLargeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIdx = categoryLargeBindingSource.Position;
            categoryL.categoryID = ((CategoryLarge)categoryLargeBindingSource.Current).CategoryLID;

            switch (e.ColumnIndex)
            {
                case 1:  //存檔
                    try
                    {
                        categoryL.categoryLName = ((CategoryLarge)categoryLargeBindingSource.Current).CategoryLName;

                        //新增
                        if (categoryL.categoryID == 0)
                        {
                            dbContext.CategoryLarges.Add(
                                new CategoryLarge
                                {
                                    CategoryLName = categoryL.categoryLName
                                });
                        }
                        else  //修改
                        {
                            var q = dbContext.CategoryLarges.Where(x => x.CategoryLID == categoryL.categoryID).FirstOrDefault();
                            q.CategoryLName = categoryL.categoryLName;
                        }

                        this.dbContext.SaveChanges();
                        ResetData();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    break;
                case 3: //刪除
                    if (categoryL.categoryID == 0)
                    {
                        MessageBox.Show("尚未存檔, 無法刪除 !");
                        return;
                    }

                    DialogResult result = MessageBox.Show("確定刪除 ?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) { return; }

                    try
                    {
                        var q = dbContext.CategoryLarges.Where(x => x.CategoryLID == categoryL.categoryID).FirstOrDefault();
                        dbContext.CategoryLarges.Remove(q);
                        this.dbContext.SaveChanges();
                        ResetData();
                    }
                    catch (Exception ex)
                    { Debug.WriteLine(ex); }
                    break;
            }
        }
    }
}
