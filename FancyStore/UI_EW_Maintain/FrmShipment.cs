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
    public partial class FrmShipment : Form
    {
        public FrmShipment()
        {
            InitializeComponent();
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();

        private void FrmShipment_Load(object sender, EventArgs e)
        {
            int yy = DateTime.Now.Year;
            int mm = DateTime.Now.Month;

            this.dateTimePicker1.Text = $"{yy}/{mm}/{1}";
            this.dateTimePicker2.Text = $"{yy}/{mm}/{DateTime.DaysInMonth(yy, mm)}";

            ResetData();
        }
        //動態產生 OrderHeader 資料
        void ResetData()
        {
            dbContext = new FancyStoreEntities(); //為了能刷新資料

            var pm = dbContext.PayMethods;
            PayMethodName.DataSource = pm.ToList();

            var os = dbContext.OrderStatusLists;
            OrderStatusName.DataSource = os.ToList();

            var sp = dbContext.Shippings;
            ShippingName.DataSource = sp.ToList();

            DateTime date_b = DateTime.Parse(dateTimePicker1.Text).Date;
            DateTime date_t = DateTime.Parse(dateTimePicker2.Text).Date;

            var o = from x in dbContext.OrderHeaders.AsEnumerable()
                    where (x.OrderDate >= date_b) && (x.OrderDate <= date_t.AddDays(1)) && x.OrderStatusID == 1
                    select x;

            orderHeaderBindingSource.DataSource = o.ToList();
            orderHeaderDataGridView.DataSource = orderHeaderBindingSource;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(dateTimePicker1.Text) > DateTime.Parse(dateTimePicker2.Text))
            {
                MessageBox.Show("[開始日期] 不可大於 [結束日期] !");
                dateTimePicker2.Text = dateTimePicker1.Text;
                dateTimePicker2.Focus();
            }
            else
            { ResetData(); }
        }

        private void orderHeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                int orderID = ((OrderHeader)orderHeaderBindingSource.Current).OrderID;

                var od = dbContext.VW_EW_OrderDetail.Where(x => x.OrderID == orderID).Select(x => x);
                vW_EW_OrderDetailBindingSource.DataSource = od.ToList();
                vW_EW_OrderDetailDataGridView.DataSource = vW_EW_OrderDetailBindingSource;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void orderHeaderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (e.ColumnIndex)
            {
                case 5:      //Click 出貨
                    int orderID = ((OrderHeader)orderHeaderBindingSource.Current).OrderID;

                    //判斷庫存是否足夠
                    if (dbContext.VW_EW_OrderDetail.Where(x => x.OrderID == orderID).Any(x => x.Balance < 0))
                    {
                        MessageBox.Show($"本張訂單有部份產品庫存不足, 請補貨後再出貨 !");
                        return;
                    }

                    var od = dbContext.VW_EW_OrderDetail.Where(x => x.OrderID == orderID);

                    FancyStoreEntities dbContext1 = new FancyStoreEntities(); //為了能 Update 資料

                    foreach (var x in od)
                    {

                        try
                        {
                            var q = dbContext1.ProductStocks
                                   .Where(p => p.ProductID == x.ProductID && p.ProductColorID == x.ProductColorID && p.ProductSizeID == x.ProductSizeID)
                                   .FirstOrDefault();

                            q.StockQTY = (int)x.Balance;

                            dbContext1.SaveChanges();

                            ResetData();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                            MessageBox.Show($"更新 [庫存] 失敗, 請找系統管理員幫忙處理 !");
                            return;
                        }
                    }

                    try
                    {
                        var oh = dbContext.OrderHeaders.Find(orderID);
                        oh.OrderStatusID = 2;

                        if (shippingID > 0)
                        {
                            oh.ShippingID = shippingID;
                        }

                        dbContext.SaveChanges();
                        MessageBox.Show($"[出貨] 完成 !");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                        MessageBox.Show($"更新 [訂單] 失敗, 請找系統管理員幫忙處理 !");
                        return;
                    }

                    ResetData();
                    break;
            }
        }


        /// <summary>
        /// 必須使用 DataGridView的 EditingControlShowing 才能讀到改變後的 value
        /// </summary>
        int shippingID = 0;

        private void orderHeaderDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            (e.Control as ComboBox).SelectedIndexChanged += FrmShipment_SelectedIndexChanged;
            (e.Control as ComboBox).Leave += FrmShipment_Leave;
        }

        private void FrmShipment_Leave(object sender, EventArgs e)
        {
            //删除委派事件
            (sender as ComboBox).SelectedIndexChanged -= new EventHandler(FrmShipment_SelectedIndexChanged);
            (sender as ComboBox).Leave -= new EventHandler(FrmShipment_Leave);
        }

        private void FrmShipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"xxxx=>{ ((ComboBox)sender).SelectedValue}");
            shippingID = (int)((ComboBox)sender).SelectedValue;
        }
    }
}