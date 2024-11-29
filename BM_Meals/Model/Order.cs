using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BM_Meals
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public System.Nullable<int> ReceiptID { get; set; }

        public System.Nullable<int> WaiterID { get; set; }

        public System.Nullable<int> OrderSerial { get; set; }

        public System.Nullable<int> LocationID { get; set; }

        public string LocationName { get; set; }

        public System.Nullable<System.DateTime> OrderDate { get; set; }

        public System.Nullable<decimal> OrderTotal { get; set; }

        public System.Nullable<int> UserID { get; set; }

        public string FullName { get; set; }

        public string OrderStatus { get; set; }
    }
}
