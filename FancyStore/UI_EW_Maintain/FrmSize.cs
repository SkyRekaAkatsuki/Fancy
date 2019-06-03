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

        private void FrmSize_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();

        void ResetData()
        {
            this.sizeBindingSource.DataSource = dbContext.Sizes.ToList();
            this.sizeDataGridView.DataSource = sizeBindingSource;
        }

        private void sizeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Size sz = new Size();
            int currentIdx = sizeBindingSource.Position;
            sz.SizeID = ((Size)sizeBindingSource.Current).SizeID;

            switch (e.ColumnIndex)
            {
                case 1:  //存檔
                    try
                    {
                        sz.SizeName = ((Size)sizeBindingSource.Current).SizeName;

                        //新增
                        if (sz.SizeID == 0)
                        {
                            dbContext.Sizes.Add(sz);
                        }
                        else  //修改
                        {
                            var q = dbContext.Sizes.Find(sz.SizeID);
                            q.SizeName = sz.SizeName;
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
                    if (sz.SizeID == 0)
                    {
                        MessageBox.Show("尚未存檔, 無法刪除 !");
                        return;
                    }

                    DialogResult result = MessageBox.Show("確定刪除 ?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) { return; }

                    try
                    {
                        var q = dbContext.Sizes.Find(sz.SizeID);

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
