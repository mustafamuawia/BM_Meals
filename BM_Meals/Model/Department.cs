using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite.EF6;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BM_Meals
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public System.Nullable<bool> Status { get; set; }

        public DbSet<Item> Items { get; set; }
    }
}
