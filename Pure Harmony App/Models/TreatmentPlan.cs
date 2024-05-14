using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    public class TreatmentPlan
    {
        public int TreatmentPlanID { get; set; }
        public int PatientID { get; set; }
        public DateTime TreatmentStartDate { get; set; }
        public DateTime TreatmentEndDate { get; set; }
        public string? MedicationSchedule { get; set; }
        public int HealthcareProfessionalID { get; set; }
    }
}
