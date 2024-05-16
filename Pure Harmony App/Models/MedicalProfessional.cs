using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    public class MedicalProfessional
    {
        public int MedicalProfessionalID { get; set; }

        public int UserID { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string ContactInformation { get; set; }

        public string EmailAddress { get; set; }



        // Navigation properties 

       

        public List<Alert> Alerts { get; set; } = new List<Alert>();

        public List<Treatment> Treatments { get; set; } = new List<Treatment>();

    }
}
