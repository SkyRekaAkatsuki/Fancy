using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_Utility
{
    public class Class1
    {
        public static List<CartItem> CartList = new List<CartItem>();
    }

    public class CartItem
    {
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategorySID { get; set; }
        public int ProductSizeID { get; set; }
        public string ProductSizeName { get; set; }
        public int ProductColorID { get; set; }
        public string ProductColorName { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
