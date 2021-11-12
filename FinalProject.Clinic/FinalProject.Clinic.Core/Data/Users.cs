using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Clinic.Core
{
    public class Users
    {

        [Key]
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        [ForeignKey("RoleId")]
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string WhatsAppNumber { get; set; }
        public string UserImage { get; set; }

        public virtual Roles Role { get; set; }
        public virtual ICollection<Clinics> Clinics { get; set; }
        public virtual ICollection<Reservations> Reservations { get; set; }
        public virtual ICollection<Testimonials> Testimonials { get; set; }
    }
}
