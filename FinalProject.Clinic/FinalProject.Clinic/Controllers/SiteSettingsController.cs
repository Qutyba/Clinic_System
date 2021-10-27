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
    [ApiController]
    [Route("[controller]")]
    public class SiteSettingsController : Controller
    {
        private readonly ISiteSettingsService oSiteSettingsService;
        public SiteSettingsController(ISiteSettingsService _oSiteSettingsService)
        {
            this.oSiteSettingsService = _oSiteSettingsService;
        }

        [HttpGet]
        [Route("SiteSettings_Get/{SiteID}")]
        [ProducesResponseType(typeof(SiteSettings), StatusCodes.Status200OK)]
        public SiteSettings SiteSettings_Get(int? SiteID)
        {
            return this.oSiteSettingsService.SiteSettings_Get(SiteID);
        }
        [HttpPost]
        [Route("SiteSettings_Update")]
        [ProducesResponseType(typeof(SiteSettings), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool SiteSettings_Update([FromBody] SiteSettings oSiteSettings)
        {
            return this.oSiteSettingsService.SiteSettings_Update(oSiteSettings);
        }
    }
}
