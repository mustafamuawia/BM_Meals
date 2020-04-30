using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BM_Meals
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
        [Column(TypeName = "real")]
        public double SellPrice { get; set; }
        [Column(TypeName = "real")]
        public double Cost { get; set; }
        public string Status { get; set; }
    }
}
