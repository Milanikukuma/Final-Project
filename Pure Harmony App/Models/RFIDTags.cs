using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    public class RFIDTags
    {
        public int RFIDTagID { get; set; }

        public int PatientID { get; set; }

        public string TagType { get; set; } // "pill", "bottle", "package" 

        public bool TagStatus { get; set; } // "active", "inactive" 

        public string RFIDCode { get; set; }



        // Navigation property 

        public Patient Patient { get; set; }
    }
}
