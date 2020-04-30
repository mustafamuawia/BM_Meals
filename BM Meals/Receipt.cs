using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BM_Meals
{
    public class Receipt
    {     
            public int ReceiptID { get; set; }
            public string ReceiptSerial { get; set; }
            public int UserID { get; set; }
            [Column(TypeName = "real")]
            public double Total { get; set; }
            public DateTime ReceiptDate { get; set; }
            public string Status { get; set; }
       
    }
}
