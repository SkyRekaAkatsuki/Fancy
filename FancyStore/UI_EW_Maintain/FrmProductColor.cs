using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;

namespace UI_EW_Maintain
{
    public partial class FrmProductColor : Form
    {
        public FrmProductColor()
        {
            InitializeComponent();
        }
        public FrmProductColor(Product prod)
        {
            InitializeComponent();

            cProd = prod;

            lblProductID.Text = cProd.ProductID.ToString();
            lblProductName.Text = cProd.ProductName;
            txtDesc.Text = cProd.Desctiption;
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        Product cProd = new Product();
        string txtFilename;

        private void FrmProductColor_Load(object sender, EventArgs e)
        {
            //將cbColor給DataSource
            var q = dbContext.Colors.ToList();
            cbColor.DataSource = q;
            ColorName.DataSource = q;
            cbColor.SelectedIndex = -1;

            ResetData();
        }

        void ResetData()
        {
            dbContext = new FancyStoreEntities();

            var q = dbContext.ProductColors.Where(x => x.ProductID == cProd.ProductID).Select(x => x);

            productColorBindingSource.DataSource = q.ToList();
            productColorDataGridView.DataSource = productColorBindingSource;
        }

        //尋找圖片
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilename = pictureBox1.ImageLocation = openFileDialog1.FileName; //圖一取出就釋放資源
            }
        }

        //存圖片檔
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilename))
            {
                MessageBox.Show($"尚未選取 [圖片] , 無法存檔");
                return;
            }
            if (cbColor.SelectedIndex < 0)
            {
                MessageBox.Show($"尚未選取 [顏色] , 無法存檔");
                return;
            }
            //判斷顏色是否重覆
            int colorID = (int)cbColor.SelectedValue;
            if( dbContext.ProductColors.Any(x => x.ProductID == cProd.ProductID && x.ColorID==colorID))
            {
                MessageBox.Show($"產品的 [顏色] 重覆 , 無法存檔");
                return;
            }

            using (FileStream fs = new FileStream(txtFilename, FileMode.Open, FileAccess.Read))
            {
                try   //寫入Photo
                {
                    Photo ph = new Photo();
                    ProductColor pc = new ProductColor();

                    byte[] data = new byte[fs.Length]; //串流讀取出來的資料都為byte
                    fs.Read(data, 0, (int)fs.Length);     //讀取資料到指定byte陣列
                    ph.Photo1 = data;

                    ph.CreateDate = DateTime.Now;

                    dbContext.Photos.Add(ph);
                    this.dbContext.SaveChanges();
                    int i = ph.PhotoID;  //取得資料庫自增ID
                    MessageBox.Show($"圖片 [新增] 資料成功 => ID: {i} ");
                    txtPhotoID.Text = ph.PhotoID.ToString();
                    txtFilename = "";
                    pictureBox1.Image = null;

                    if (i > 0)  //寫入ProductColor
                    {
                        pc.ProductID = cProd.ProductID;
                        pc.PhotoID = ph.PhotoID;
                        pc.ColorID = (int)cbColor.SelectedValue;
                        pc.CreateDate = ph.CreateDate;
                        dbContext.ProductColors.Add(pc);
                        dbContext.SaveChanges();

                        ResetData();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    MessageBox.Show("圖片 [新增] 資料失敗, 請檢查欄位資料後再試一下, 或找系統管理員協助處理 !");
                    txtPhotoID.Text = "";
                }
            }
        }

        //連動show圖片
        private void productColorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)((ProductColor)productColorBindingSource.Current).PhotoID;

                byte[] data = dbContext.Photos.Find(id).Photo1;
                MemoryStream ms = new MemoryStream(data);
                Bitmap bmp = new Bitmap(ms);
                pictureBox2.Image = bmp;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void productColorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                // EntityFramework 使用Sql Command, 一次刪除多筆資料
                //dbContext.Database.ExecuteSqlCommand("delete aaa where aaa.id = @CategoryLID", new SqlParameter("@CategoryLI", cl.CategoryLID));


                case 1:      //Click 刪除
                    if (MessageBox.Show("確定要刪除嗎?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (HasProductDetails()) //有Details資料
                        {
                            MessageBox.Show($"ProductID:{cProd.ProductID} ({cProd.ProductName}) 有存在 [庫存量] 資料, 不能刪除 !");
                            return;
                        }
                        try
                        {
                            int photoID;
                            if (int.TryParse(((ProductColor)productColorBindingSource.Current).PhotoID.ToString(), out photoID))
                            {
                                var p = dbContext.Photos.Find(photoID);
                                dbContext.Photos.Remove(p);
                                dbContext.SaveChanges();
                            }
                            int prodColorID = ((ProductColor)productColorBindingSource.Current).ProductColorID;
                            var n = dbContext.ProductColors.Find(prodColorID);

                            dbContext.ProductColors.Remove(n);
                            dbContext.SaveChanges();
                            { MessageBox.Show("顏色 [刪除] 資料成功 !"); }
                            ResetData();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                            MessageBox.Show("顏色 [刪除] 資料失敗, 請檢查欄位資料後再試一下, 或找系統管理員協助處理 !");
                        }
                    }
                    break;
            }
        }

        //判斷Product是否有其他Details資料
        bool HasProductDetails()
        {
            if (dbContext.ProductStocks.Any(x => x.ProductID == cProd.ProductID))  // 有ProductStock
            { return true; }

            return false;  //無任何Details資料
        }
    }
}
