using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Models
{
    public class Treatment
    {
        public int TreatmentID { get; set; }

        public string Description { get; set; }

        public int DiseaseID { get; set; } // Foreign key to Disease 

        public string Schedule { get; set; } // "Daily", "Twice a day", etc. 

        public int MedicalProfessionalID { get; set; } // Foreign key to MedicalProfessional 



        // Navigation properties 

        public Disease Disease { get; set; }

        public MedicalProfessional MedicalProfessional { get; set; }

        public List<Treatment> PatientTreatments { get; set; } = new List<Treatment>();

    }
}
