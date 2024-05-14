using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    public class MedicationAdherence
    {
        public int AdherenceID { get; set; }
        public int PatientID { get; set; }
        public int TreatmentPlanID { get; set; }
        public DateTime Date { get; set; }
        public bool MedicationTaken { get; set; } // true for yes, false for no
      
    }
}
