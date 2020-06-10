using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace BM_Meals
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        public string LocationName { get; set; }

        public System.Nullable<int> PlaceID { get; set; }

        public static implicit operator Location(string v)
        {
            throw new NotImplementedException();
        }
    }
}
