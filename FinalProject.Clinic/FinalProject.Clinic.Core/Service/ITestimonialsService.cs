using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Service
{
    public interface ITestimonialsService
    {
        List<Testimonials> Testimonials_Get(int? SiteID);
        bool Testimonials_Insert(Testimonials oTestimonials);
        bool Testimonials_Activate(int testimonialID);
        bool Testimonials_Delete(int testimonialID);
    }
}
