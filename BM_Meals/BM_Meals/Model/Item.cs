using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BM_Meals
{
    public class Item
    {
        [Key]
        public int ItemsID { get; set; }

        public string ItemName { get; set; }

        public System.Nullable<int> CategoryID { get; set; }

        public System.Nullable<decimal> ItemSellPrice { get; set; }

        public string ItemImage { get; set; }

        public System.Nullable<int> DepartmentID { get; set; }

        public System.Nullable<bool> ItemStatus { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Department> Department { get; set; }
    }
}
