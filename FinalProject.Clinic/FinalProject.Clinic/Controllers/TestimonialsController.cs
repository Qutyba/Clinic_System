using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Clinic.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestimonialsController : Controller
    {
        private readonly ITestimonialsService oTestimonialsService;
        public TestimonialsController(ITestimonialsService _oTestimonialsService)
        {
            this.oTestimonialsService = _oTestimonialsService;
        }

        [HttpGet]
        [Route("Testimonials_Get/{SiteID}")]
        [ProducesResponseType(typeof(List<Testimonials>), StatusCodes.Status200OK)]
        public List<Testimonials> Testimonials_Get(int? SiteID)
        {
            return this.oTestimonialsService.Testimonials_Get(SiteID);
        }
        [HttpPut]
        [Route("Testimonials_Activate/{testimonialID}")]
        public bool Testimonials_Activate(int testimonialID)
        {
            return this.oTestimonialsService.Testimonials_Activate(testimonialID);
        }
        [HttpDelete]
        [Route("Testimonials_Delete/{testimonialID}")]
        public bool Testimonials_Delete(int testimonialID)
        {
            return this.oTestimonialsService.Testimonials_Delete(testimonialID);
        }
        [HttpPost]
        [ProducesResponseType(typeof(Testimonials), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Testimonials_Insert([FromBody] Testimonials oTestimonials)
        {
            return this.oTestimonialsService.Testimonials_Insert(oTestimonials);
        }
    }
}
