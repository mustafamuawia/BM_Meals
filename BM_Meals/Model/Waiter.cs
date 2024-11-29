using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BM_Meals
{
    public class Waiter
    {
        [Key]
        public int WaiterID { get; set; }

        public string WaiterName { get; set; }

        public System.Nullable<bool> WaiterStatus { get; set; }
    }
}
