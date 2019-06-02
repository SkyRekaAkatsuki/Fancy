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

        internal static class clsColor
        {
            internal static int ColorID { get; set; }
            internal static string ColorName { get; set; }
            internal static Nullable<int> R { get; set; }
            internal static Nullable<int> G { get; set; }
            internal static Nullable<int> B { get; set; }
        }


        private void colorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIdx = colorBindingSource.Position;
            clsColor.ColorID = ((DB_Fancy.Color)colorBindingSource.Current).ColorID;

            switch (e.ColumnIndex)
            {
                case 4:  //存檔
                    try
                    {
                        clsColor.ColorName = ((DB_Fancy.Color)colorBindingSource.Current).ColorName;
                        clsColor.R = ((DB_Fancy.Color)colorBindingSource.Current).R;
                        clsColor.G = ((DB_Fancy.Color)colorBindingSource.Current).G;
                        clsColor.B = ((DB_Fancy.Color)colorBindingSource.Current).B;

                        //新增
                        if (clsColor.ColorID == 0)
                        {
                            dbContext.Colors.Add(
                                new DB_Fancy.Color
                                {
                                    ColorName = clsColor.ColorName,
                                    R = clsColor.R,
                                    G = clsColor.G,
                                    B = clsColor.B
                                });
                        }
                        else  //修改
                        {
                            var q = dbContext.Colors.Where(x => x.ColorID == clsColor.ColorID).FirstOrDefault();
                            q.ColorName = clsColor.ColorName;
                            q.R = clsColor.R;
                            q.G = clsColor.G;
                            q.B = clsColor.B;
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
                    if (clsColor.ColorID == 0)
                    {
                        MessageBox.Show("尚未存檔, 無法刪除 !");
                        return;
                    }

                    DialogResult result = MessageBox.Show("確定刪除 ?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) { return; }

                    try
                    {
                        var q = dbContext.Colors.Where(x => x.ColorID == clsColor.ColorID).FirstOrDefault();
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
