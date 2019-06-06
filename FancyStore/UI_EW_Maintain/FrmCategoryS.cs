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
using DB_Fancy;

namespace UI_EW_Maintain
{
    public partial class FrmCategoryS : Form
    {
        public FrmCategoryS()
        {
            InitializeComponent();
        }

        private void FrmCategoryS_Load(object sender, EventArgs e)
        {
            this.categoryMiddleBindingSource.DataSource = dbContext.CategoryMiddles.ToList();
            this.categoryMiddleDataGridView.DataSource = categoryMiddleBindingSource;
            this.categoryLargeBindingSource.DataSource = dbContext.CategoryLarges.ToList();

            //ResetData();
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        CategoryMiddle cm = new CategoryMiddle();

        void ResetData(int catM)
        {
            this.categorySmallBindingSource.DataSource = dbContext.CategorySmalls.Where(x => x.CategoryMID == catM).ToList();
            this.categorySmallDataGridView.DataSource = categorySmallBindingSource;
        }
        
        //讀取中分類目前所在位置的值
        private void categoryMiddleBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            cm.CategoryMID = ((CategoryMiddle)categoryMiddleBindingSource.Current).CategoryMID;
            cm.CategoryMName = ((CategoryMiddle)categoryMiddleBindingSource.Current).CategoryMName;

            ResetData(cm.CategoryMID);
        }

        private void categorySmallDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategorySmall cs = new CategorySmall();
            int currentIdx = categorySmallBindingSource.Position;
            cs.CategorySID = ((CategorySmall)categorySmallBindingSource.Current).CategorySID;

            switch (e.ColumnIndex)
            {
                case 1:  //存檔
                    try
                    {
                        cs.CategorySName = ((CategorySmall)categorySmallBindingSource.Current).CategorySName;
                        cs.CategoryMID = cm.CategoryMID;

                        //新增
                        if (cs.CategorySID == 0)
                        {
                            dbContext.CategorySmalls.Add(cs);
                        }
                        else  //修改
                        {
                            var q = dbContext.CategorySmalls.Find(cs.CategorySID);
                            q.CategorySName = cs.CategorySName;
                        }

                        this.dbContext.SaveChanges();
                        ResetData(cm.CategoryMID);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    break;
                case 3: //刪除
                    if (cs.CategorySID == 0)
                    {
                        MessageBox.Show("尚未存檔, 無法刪除 !");
                        return;
                    }

                    DialogResult result = MessageBox.Show("確定刪除 ?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) { return; }

                    try
                    {
                        var q = dbContext.CategorySmalls.Find(cs.CategorySID);

                        dbContext.CategorySmalls.Remove(q);
                        this.dbContext.SaveChanges();
                        ResetData(cm.CategoryMID);
                    }
                    catch (Exception ex)
                    { Debug.WriteLine(ex); }
                    break;
            }
        }
    }
}
