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
        public int UserID { get; set; }

        public string UserType { get; set; } // "Patient", "Medical" 

        public string Username { get; set; }

        public string Password { get; set; }



        // Navigation property 

        public Patient Patient { get; set; } // If UserType is "Patient" 

        public MedicalProfessional MedicalProfessional { get; set; } // If UserType is "Medical" 

       

    }
}
