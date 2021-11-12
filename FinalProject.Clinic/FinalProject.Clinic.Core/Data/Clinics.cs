using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Clinic.Core
{
    public class Clinics
    {
       
        [Key]
        public int? ClinicId { get; set; }
        public string ClinicName { get; set; }
        public int? ManagerId { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]

        public string Logo { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public int? Floor { get; set; }
        public int? ApartmentNumber { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string ClinicDescription { get; set; }
        public string DoctorsList { get; set; }
        public int? ReservationTimeSlot { get; set; }
        public string TelNumber { get; set; }
        public string MobileNumber { get; set; }

        public virtual ClinicCategory Category { get; set; }
        public virtual Users Manager { get; set; }
        public virtual ICollection<Reservations> Reservations { get; set; }
        public virtual ICollection<Vacations> Vacations { get; set; }
        public virtual ICollection<WorkingHours> WorkingHours { get; set; }
    }
}
