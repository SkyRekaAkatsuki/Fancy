using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cls_Utility
{
    public class EW_Library
    {
        public static bool _IsProdInsertOK;  //產品資料是否Insert成功
        public static bool _IsProdUpdateOK;  //產品資料是否Update成功
        public static bool _IsProdDeleteOK;  //產品資料是否Delete成功
        public static int _ProductID = 0;  //傳遞用的 product ID
        public static int _UserID;
        public static bool _IsOrderUpdateOK;  //Order資料是否Update成功


        //共用之連線字串
        public static string strConn = ConfigurationManager.ConnectionStrings["DB_Fancy.Properties.Settings.FancyConnectionString"].ConnectionString;

        public class clsProd
        {
            public int ProdID { get; set; }
            public string prodName { get; set; }
            public string desc { get; set; }
            public int categorySID { get; set; }
            public decimal price { get; set; }
            public int SupplierID { get; set; }
            public DateTime prodInDate { get; set; }
            public DateTime prodOutDate { get; set; }
        }

        /// <summary>
        /// UpdateOrder()  :  OrderUdate
        /// </summary>
        public bool UpdateOrder(string orderNum)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strSQL = @"  Update Orders"
                                    + @"  Set IsCancel= 1"
                                    + @"  where OrderNum = @OrderNum;";

                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    //訂單編號
                    cmd.Parameters.Add(new SqlParameter("@OrderNum", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = orderNum,
                    });

                    //開啓連線
                    conn.Open();

                    //TODO ===================================
                    //定義Transaction
                    SqlTransaction myTrans = conn.BeginTransaction();
                    cmd.Transaction = myTrans;

                    try
                    {
                        cmd.ExecuteNonQuery();  //執行SQL

                        myTrans.Commit();
                        _IsOrderUpdateOK = true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                        myTrans.Rollback();
                        _IsOrderUpdateOK = false;
                    }
                }
            }

            return _IsOrderUpdateOK;
        }

        /// <summary>
        /// DeleteProduct()  :  產品Delete
        /// </summary>
        public bool DeleteProduct(clsProd cProd)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strSQL = @"  delete ProductStock where ProductID = @ProductID;"
                                    + @"  delete ProductColor where ProductID = @ProductID;"
                                    + @"  delete ProductSize where ProductID = @ProductID;"
                                    + @"  delete Products where ProductID = @ProductID;";

                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    //產品ID
                    cmd.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = cProd.ProdID,
                    });

                    //開啓連線
                    conn.Open();

                    //TODO ===================================
                    //定義Transaction
                    SqlTransaction myTrans = conn.BeginTransaction();
                    cmd.Transaction = myTrans;

                    try
                    {
                        cmd.ExecuteNonQuery();  //執行SQL

                        myTrans.Commit();
                        _IsProdDeleteOK = true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                        myTrans.Rollback();
                        _IsProdDeleteOK = false;
                    }
                }
            }

            return _IsProdDeleteOK;
        }

        /// <summary>
        /// UpdateProduct()  :  產品Udate
        /// </summary>
        public bool UpdateProduct(clsProd cProd)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strSQL = @"  Update Products"
                                    + @"  Set ProductName=@ProductName,Desctiption=@Desctiption,CategorySID=@CategorySID,"
                                    + @"  UnitPrice=@UnitPrice,ProductInDate=@ProductInDate,ProductOutDate=@ProductOutDate"
                                    + @"  where ProductID = @ProductID;";

                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    //產品ID
                    cmd.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = cProd.ProdID,
                    });

                    cmd.CommandType = CommandType.Text;
                    //產品名稱
                    cmd.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar, 50)
                    {
                        Direction = ParameterDirection.Input,
                        Value = cProd.prodName,
                    });

                    //產品品名規格詳細敍述
                    cmd.Parameters.Add(new SqlParameter("@Desctiption", SqlDbType.NVarChar, 250)
                    {
                        Direction = ParameterDirection.Input,
                        Value = cProd.desc,
                    });

                    //小分類ID
                    cmd.Parameters.Add(new SqlParameter("@CategorySID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = cProd.categorySID,
                    });

                    //單價
                    cmd.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Decimal)
                    {
                        Direction = ParameterDirection.Input,
                        Value = cProd.price,
                        Precision = 10,  //全部10位數
                        Scale = 2,         //小數2位數
                    });

                    //上架日期
                    cmd.Parameters.Add(new SqlParameter("@ProductInDate", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        Value = cProd.prodInDate,
                    });

                    //下架日期
                    cmd.Parameters.Add(new SqlParameter("@ProductOutDate", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        Value = cProd.prodOutDate,
                    });

                    //開啓連線
                    conn.Open();

                    //TODO ===================================
                    //定義Transaction
                    SqlTransaction myTrans = conn.BeginTransaction();
                    cmd.Transaction = myTrans;

                    try
                    {
                        cmd.ExecuteNonQuery();  //執行SQL

                        myTrans.Commit();
                        _IsProdUpdateOK = true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                        myTrans.Rollback();
                        _IsProdUpdateOK = false;
                    }
                }
            }

            return _IsProdUpdateOK;
        }

        /// <summary>
        /// InsertProduct()  :  產品Insert
        /// </summary>
        public bool InsertProduct(clsProd prod)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strSQL = @"Insert Into Products (ProductName,Desctiption,CategorySID,UnitPrice,SupplierID,ProductInDate,ProductOutDate) values "
                                         + @" (@ProductName,@Desctiption,@CategorySID,@UnitPrice,0,@ProductInDate,@ProductOutDate);"
                                        + @"select @ID = SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    //產品名稱
                    cmd.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar, 50)
                    {
                        Direction = ParameterDirection.Input,
                        Value = prod.prodName,
                    });

                    //產品品名規格詳細敍述
                    cmd.Parameters.Add(new SqlParameter("@Desctiption", SqlDbType.NVarChar, 250)
                    {
                        Direction = ParameterDirection.Input,
                        Value = prod.desc,
                    });

                    //小分類ID
                    cmd.Parameters.Add(new SqlParameter("@CategorySID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = prod.categorySID,
                    });

                    //單價
                    cmd.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Decimal)
                    {
                        Direction = ParameterDirection.Input,
                        Value = prod.price,
                        Precision = 10,  //全部10位數
                        Scale = 2,         //小數2位數
                    });

                    //上架日期
                    cmd.Parameters.Add(new SqlParameter("@ProductInDate", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        Value = prod.prodInDate,
                    });

                    //下架日期
                    cmd.Parameters.Add(new SqlParameter("@ProductOutDate", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        Value = prod.prodOutDate,
                    });

                    //取得ID
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output,
                    });

                    //開啓連線
                    conn.Open();

                    //TODO ===================================
                    //定義Transaction
                    SqlTransaction myTrans = conn.BeginTransaction();
                    cmd.Transaction = myTrans;

                    try
                    {
                        cmd.ExecuteNonQuery();  //執行SQL

                        //得到 Product ID
                        _ProductID = prod.ProdID = (int)cmd.Parameters["@ID"].Value;

                        //MessageBox.Show($"新產品ID = {_ProductID}");

                        myTrans.Commit();
                        _IsProdInsertOK = true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                        myTrans.Rollback();
                        _IsProdInsertOK = false;
                    }
                }
            }

            return _IsProdInsertOK;
        }
    }
}
