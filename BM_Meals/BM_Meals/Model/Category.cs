using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BM_Meals
{
    public partial class Category 
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public System.Nullable<int> CategoryStatus { get; set; }

        public DbSet<Item> Items { get; set; }

    }
}
