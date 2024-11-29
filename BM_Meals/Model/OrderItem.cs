using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BM_Meals
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        public System.Nullable<int> OrderID { get; set; }

        public System.Nullable<int> ItemID { get; set; }

        public string ItemText { get; set; }

        public System.Nullable<decimal> ItemPrice { get; set; }

        public System.Nullable<int> ItemQTY { get; set; }

        public System.Nullable<decimal> TotalPrice { get; set; }
    }
}
