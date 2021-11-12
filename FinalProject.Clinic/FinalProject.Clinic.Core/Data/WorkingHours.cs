using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Clinic.Core
{
    public class WorkingHours
    {
        [Key]
        public int? WorkingHoursId { get; set; }
        public int? ClinicId { get; set; }
        [ForeignKey("ClinicId")]
        public int? DayId { get; set; }
        public DateTime WorkingFrom { get; set; }
        public DateTime WorkingTo { get; set; }
        public DateTime? BreakFrom { get; set; }
        public DateTime? BreakTo { get; set; }

        public virtual Clinics Clinic { get; set; }
        public virtual Days Day { get; set; }
    }
}
