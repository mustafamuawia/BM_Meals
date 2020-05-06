using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM_Meals.Model
{
    public class User 
    {
        public int UserID { get; set; }

        public string Username { get; set; }

        public string UserPassword { get; set; }

        public string FullName { get; set; }

        public string UserRole { get; set; }

        public string UserStatus { get; set; }
     }
}
