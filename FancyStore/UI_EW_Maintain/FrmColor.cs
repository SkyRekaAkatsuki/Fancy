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

namespace UI_EW_Maintain
{
    public partial class FrmColor : Form
    {
        public FrmColor()
        {
            InitializeComponent();
        }

        private void FrmColor_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();

        void ResetData()
        {
            this.colorBindingSource.DataSource = dbContext.Colors.ToList();
            this.colorDataGridView.DataSource = colorBindingSource;
        }


        private void colorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DB_Fancy.Color co = new DB_Fancy.Color();
            int currentIdx = colorBindingSource.Position;
            co.ColorID = ((DB_Fancy.Color)colorBindingSource.Current).ColorID;

            switch (e.ColumnIndex)
            {
                case 4:  //存檔
                    try
                    {
                        co.ColorName = ((DB_Fancy.Color)colorBindingSource.Current).ColorName;
                        co.R = ((DB_Fancy.Color)colorBindingSource.Current).R;
                        co.G = ((DB_Fancy.Color)colorBindingSource.Current).G;
                        co.B = ((DB_Fancy.Color)colorBindingSource.Current).B;

                        //新增
                        if (co.ColorID == 0)
                        {
                            dbContext.Colors.Add(co);
                        }
                        else  //修改
                        {
                            var q = dbContext.Colors.Find(co.ColorID);
                            q.ColorName = co.ColorName;
                            q.R = co.R;
                            q.G = co.G;
                            q.B = co.B;
                        }

                        this.dbContext.SaveChanges();
                        ResetData();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    break;
                case 6: //刪除
                    if (co.ColorID == 0)
                    {
                        MessageBox.Show("尚未存檔, 無法刪除 !");
                        return;
                    }

                    DialogResult result = MessageBox.Show("確定刪除 ?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) { return; }

                    try
                    {
                        var q = dbContext.Colors.Find(co.ColorID);
                        dbContext.Colors.Remove(q);
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
