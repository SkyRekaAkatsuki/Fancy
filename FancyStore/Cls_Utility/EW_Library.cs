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
    public static class _clsProd
    {
        public static int _ProductID { get; set; }
        public static string _ProductName { get; set; }
        public static string _Desctiption { get; set; }
        public static int _CategorySID { get; set; }
        public static int _UnitPrice { get; set; }
        public static Nullable<int> _SupplierID { get; set; }
        public static Nullable<System.DateTime> _ProductInDate { get; set; }
        public static Nullable<System.DateTime> _ProductOutDate { get; set; }
        public static Nullable<System.DateTime> _CreateDate { get; set; }
    }

    public class EW_Library
    {
    }
}
