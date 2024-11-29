using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BM_Meals
{
    public class User 
    {
        [Key]
        public int UserID { get; set; }

        public string Username { get; set; }

        public string UserPassword { get; set; }

        public string FullName { get; set; }

        public string UserRole { get; set; }

        public string UserStatus { get; set; }
     }
}
