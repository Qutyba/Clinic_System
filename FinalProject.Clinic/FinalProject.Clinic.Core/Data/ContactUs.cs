﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Clinic.Core
{
    public class ContactUs
    {
        [Key]
        public int ContactId { get; set; }
        public int SiteId { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public virtual SiteSettings Site { get; set; }
    }
}
