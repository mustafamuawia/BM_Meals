using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BM_Meals
{
    public class Place
    {
        [Key]
        public int PlaceID { get; set; }

        public string PlaceName { get; set; }

        public System.Nullable<decimal> ServiceFees { get; set; }

        public System.Nullable<bool> PlaceStatus { get; set; }
    }
}
