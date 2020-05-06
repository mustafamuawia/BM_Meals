using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM_Meals.Model
{
    class Department
    {
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public System.Nullable<bool> Status { get; set; }

        public DbSet<Item> Items { get; set; }
    }
}
