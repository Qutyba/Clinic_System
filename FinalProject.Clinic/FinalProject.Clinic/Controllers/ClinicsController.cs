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
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicsService clinicsService;
        public ClinicsController(IClinicsService _clinicsService)
        {
            clinicsService = _clinicsService;
        }

        [HttpGet]
        [Route("Clinics_Get")]
        [ProducesResponseType(typeof(List<Clinics>),StatusCodes.Status200OK)]
        public List<Clinics> Clinics_Get(Clinics clinics)
        {
            return clinicsService.Clinics_Get(clinics);
        }

        [HttpPost]
        [Route("Clinics_Insert")]
        [ProducesResponseType(typeof(Clinics),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Clinics_Insert([FromBody] Clinics clinics)
        {
            return clinicsService.Clinics_Insert(clinics);
        }

        [HttpPut]
        [Route("Clinics_Update")]
        [ProducesResponseType(typeof(List<Clinics>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Clinics_Update([FromBody]Clinics clinics)
        {
            return clinicsService.Clinics_Update(clinics);
        }

        [HttpDelete]
        [Route("Clinics_Delete/{id}")]
        public bool Clinics_Delete(int id)
        {
            return clinicsService.Clinics_Delete(id);
        }

    }
}
