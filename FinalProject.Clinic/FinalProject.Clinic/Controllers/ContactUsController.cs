using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Clinic.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService oContactUsService;
        public ContactUsController(IContactUsService _oContactUsService)
        {
            this.oContactUsService = _oContactUsService;
        }

        [HttpGet]
        [Route("ContactUs_Get/{SiteID}")]
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        public List<ContactUs> ContactUs_Get(int? SiteID)
        {
            return this.oContactUsService.ContactUs_Get(SiteID);
        }
        [HttpDelete]
        [Route("ContactUs_Delete/{contactID}")]
        public bool ContactUs_Delete(int contactID)
        {
            return this.oContactUsService.ContactUs_Delete(contactID);
        }

        [HttpPost]
        [Route("ContactUs_Insert")]
        [ProducesResponseType(typeof(ContactUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool ContactUs_Insert([FromBody] ContactUs oContactUs)
        {
            return this.oContactUsService.ContactUs_Insert(oContactUs);
        }
    }
}
