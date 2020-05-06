using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM_Meals.Model
{
    class Receipt
    {
        public int ReceiptID { get; set; }

        public System.Nullable<int> ReceiptSerial { get; set; }

        public System.Nullable<System.DateTime> ReceiptDate { get; set; }

        public System.Nullable<decimal> ReceiptTotal { get; set; }

        public System.Nullable<int> UserID { get; set; }

        public System.Nullable<int> WaiterID { get; set; }

        public System.Nullable<int> LocationID { get; set; }

        public System.Nullable<int> WorkPeriodID { get; set; }

        public System.Nullable<int> ServiceTypeID { get; set; }

        public System.Nullable<decimal> ServiceFees { get; set; }

        public string ReceiptStatus { get; set; }

    }
}
