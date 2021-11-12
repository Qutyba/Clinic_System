using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Clinic.Core
{
    public class Reservations
    {
        [Key]
        public int? ReservationId { get; set; }
        public int? ClinicId { get; set; }
        [ForeignKey("ClinicId")]
        public int? PatientId { get; set; }
        [ForeignKey("PatientId")]

        public DateTime? ReservationDate { get; set; }
        public DateTime? ReservationFrom { get; set; }
        public DateTime? ReservationTo { get; set; }

        public virtual Clinics Clinic { get; set; }
        public virtual Users ClinicNavigation { get; set; }
    }
}
