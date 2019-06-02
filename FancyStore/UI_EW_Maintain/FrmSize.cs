using DB_Fancy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Size = DB_Fancy.Size;

namespace UI_EW_Maintain
{
    public partial class FrmSize : Form
    {
        public FrmSize()
        {
            InitializeComponent();
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();

        private void FrmSize_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        void ResetData()
        {
            this.sizeBindingSource.DataSource = dbContext.Sizes.ToList();
            this.sizeDataGridView.DataSource = sizeBindingSource;
        }

        internal static class clsSize
        {
            internal static int sizeID { get; set; }
            internal static string sizeName { get; set; }
        }

        private void sizeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIdx = sizeBindingSource.Position;
            clsSize.sizeID = ((DB_Fancy.Size)sizeBindingSource.Current).SizeID;

            switch (e.ColumnIndex)
            {
                case 0:  //存檔
                    try
                    {
                        clsSize.sizeName = ((DB_Fancy.Size)sizeBindingSource.Current).SizeName;

                        //新增
                        if (clsSize.sizeID == 0)
                        {
                            dbContext.Sizes.Add(
                                new Size
                                {
                                    SizeName = clsSize.sizeName
                                });
                        }
                        else  //修改
                        {
                            var q = dbContext.Sizes.Where(x => x.SizeID == clsSize.sizeID).FirstOrDefault();
                            q.SizeName = clsSize.sizeName;
                        }

                        this.dbContext.SaveChanges();
                        ResetData();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    break;
                case 1: //刪除
                    if (clsSize.sizeID == 0)
                    {
                        MessageBox.Show("尚未存檔, 無法刪除 !");
                        return;
                    }

                    DialogResult result = MessageBox.Show("確定刪除 ?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) { return; }

                    try
                    {
                        var q = dbContext.Sizes.Where(x => x.SizeID == clsSize.sizeID).FirstOrDefault();

                        dbContext.Sizes.Remove(q);
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
