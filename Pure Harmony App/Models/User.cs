using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
