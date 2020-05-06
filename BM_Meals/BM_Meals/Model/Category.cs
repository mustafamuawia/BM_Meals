using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM_Meals.Model
{
    public partial class Category 
    {

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public System.Nullable<int> CategoryStatus { get; set; }

        public DbSet<Item> Items { get; set; }

    }
}
