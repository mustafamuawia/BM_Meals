using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BM_Meals
{
    public class ReceiptDetails
    {
        public int ReceiptDetailsID { get; set; }
        public int ReceiptID { get; set; }
        public int ItemID { get; set; }
        public int ItemName { get; set; }
        [Column(TypeName = "real")]
        public double SellPrice { get; set; }
        [Column(TypeName = "real")]
        public double Cost { get; set; }
        [Column(TypeName = "real")]
        public double Quantity { get; set; }
        [Column(TypeName = "real")]
        public int Total { get; set; }
        public string Status { get; set; }
    }
}
