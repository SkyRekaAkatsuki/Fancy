using DB_Fancy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            //Console.WriteLine("===============start===================");

            //Console.WriteLine(dbContext.Database.Connection.ConnectionString);//app.config

            //dbContext.Database.Log = Console.Write;
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

        private void categoryLargeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //cl.CategoryLID = ((CategoryLarge)categoryLargeBindingSource.Current).CategoryLID;
            //cl.CategoryLName = ((CategoryLarge)categoryLargeBindingSource.Current).CategoryLName;
        }

        private void categoryLargeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryLarge cl = new CategoryLarge();
            int currentIdx = categoryLargeBindingSource.Position;
            cl.CategoryLID = ((CategoryLarge)categoryLargeBindingSource.Current).CategoryLID;

            switch (e.ColumnIndex)
            {
                case 1:  //存檔
                    try
                    {
                        cl.CategoryLName = ((CategoryLarge)categoryLargeBindingSource.Current).CategoryLName;
                        //新增
                        if (cl.CategoryLID == 0)
                        {
                            dbContext.CategoryLarges.Add(cl);
                        }
                        else  //修改
                        {
                            //var q = dbContext.CategoryLarges.Where(x => x.CategoryLID == categoryL.categoryID).FirstOrDefault();
                            var q = dbContext.CategoryLarges.Find(cl.CategoryLID);

                            q.CategoryLName = cl.CategoryLName;
                        }

                        this.dbContext.SaveChanges();

                        //int id = cl.CategoryLID;
                        //MessageBox.Show($"id={id}");

                        ResetData();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    break;
                case 3: //刪除
                    if (cl.CategoryLID == 0)
                    {
                        MessageBox.Show("尚未存檔, 無法刪除 !");
                        return;
                    }

                    DialogResult result = MessageBox.Show("確定刪除 ?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) { return; }

                    try
                    {
                        //var q = dbContext.CategoryLarges.Where(x => x.CategoryLID == categoryL.categoryID).FirstOrDefault();
                        var q = dbContext.CategoryLarges.Find(cl.CategoryLID);
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
