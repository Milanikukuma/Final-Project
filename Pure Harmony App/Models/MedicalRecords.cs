using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pure_Harmony_App.Models
{
    public class MedicalRecords
    {
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        public DateTime Date { get; set; }
        public string? Description { get; set; }
        // Add more properties as needed
    }
}
