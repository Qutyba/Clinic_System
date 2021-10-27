using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Infra.Service
{
    public class TestimonialsService : ITestimonialsService
    {
        private readonly ITestimonialsRepository oTestimonialsRepository;
        public TestimonialsService(ITestimonialsRepository _oTestimonialsRepository)
        {
            this.oTestimonialsRepository = _oTestimonialsRepository;
        }
        public bool Testimonials_Activate(int testimonialID)
        {
            return this.oTestimonialsRepository.Testimonials_Activate(testimonialID);
        }

        public bool Testimonials_Delete(int testimonialID)
        {
            return this.oTestimonialsRepository.Testimonials_Delete(testimonialID);
        }

        public List<Testimonials> Testimonials_Get(int? SiteID)
        {
            return this.oTestimonialsRepository.Testimonials_Get(SiteID);
        }

        public bool Testimonials_Insert(Testimonials oTestimonials)
        {
            return this.oTestimonialsRepository.Testimonials_Insert(oTestimonials);
        }
    }
}
