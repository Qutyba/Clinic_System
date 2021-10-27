using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Service;

namespace FinalProject.Clinic.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DaysController : Controller
    {
        public readonly IDaysService daysService;

        public DaysController(IDaysService daysService)
        {
            this.daysService = daysService;

        }
        [HttpGet]
        [Route("Days_Get")]
        [ProducesResponseType(typeof(List<Days>), StatusCodes.Status200OK)]
        public List<Days> Days_Get()
        {
            return daysService.Days_Get();
        }

    }
}
