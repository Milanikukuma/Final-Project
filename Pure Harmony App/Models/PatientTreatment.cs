using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    internal class PatientTreatment
    {
        public int PatientTreatmentID { get; set; }

        public int PatientID { get; set; }

        public DateTime TreatmentStartDate { get; set; }

        public DateTime? TreatmentEndDate { get; set; } // Nullable for ongoing treatments 

        public int TreatmentID { get; set; }



        // Navigation property 

        public Patient Patient { get; set; }

        public PatientTreatment Treatment { get; set; }
    }
}
