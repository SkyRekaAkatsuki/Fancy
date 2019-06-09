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
    public partial class FrmProductPhoto : Form
    {
        public FrmProductPhoto()
        {
            InitializeComponent();
        }
        public FrmProductPhoto(Product prod)
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

        private void FrmProductPhoto_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        void ResetData()
        {
            dbContext = new FancyStoreEntities();

            var q = dbContext.ProductPhotoes.Where(x => x.ProductID == cProd.ProductID).Select(x => x);

            productPhotoBindingSource.DataSource = q.ToList();
            productPhotoDataGridView.DataSource = productPhotoBindingSource;
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
            if (string.IsNullOrWhiteSpace( txtFilename))
            {
                MessageBox.Show($"尚未選取圖片, 無法存檔");
                return;
            }
            using (FileStream fs = new FileStream(txtFilename, FileMode.Open, FileAccess.Read))
            {
                try   //寫入Photo
                {
                    Photo ph = new Photo();
                    ProductPhoto pp = new ProductPhoto();

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

                    if (i > 0)  //寫入ProductPhoto
                    {
                        pp.ProductID = cProd.ProductID;
                        pp.PhotoID = ph.PhotoID;
                        pp.CreateDate = ph.CreateDate;
                        dbContext.ProductPhotoes.Add(pp);
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
        private void productPhotoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)((ProductPhoto)productPhotoBindingSource.Current).PhotoID;

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

        private void productPhotoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:      //Click 刪除
                    if (MessageBox.Show("確定要刪除嗎?", "刪除作業", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int photoID;
                            if (int.TryParse(((ProductPhoto)productPhotoBindingSource.Current).PhotoID.ToString(), out photoID))
                            {
                                var p = dbContext.Photos.Find(photoID);
                                dbContext.Photos.Remove(p);
                                dbContext.SaveChanges();
                            }
                            int prodPhotoID = ((ProductPhoto)productPhotoBindingSource.Current).ProductPhotoID;
                            var n = dbContext.ProductPhotoes.Find(prodPhotoID);

                            dbContext.ProductPhotoes.Remove(n);
                            dbContext.SaveChanges();
                            { MessageBox.Show("圖片 [刪除] 資料成功 !"); }
                            ResetData();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                            MessageBox.Show("圖片 [刪除] 資料失敗, 請檢查欄位資料後再試一下, 或找系統管理員協助處理 !");
                        }
                    }
                    break;
            }
        }
    }
}
