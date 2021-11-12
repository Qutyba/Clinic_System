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
    public class VacationsController : ControllerBase
    {
        private readonly IVacationsService vacationsService;
        public VacationsController(IVacationsService _vacationsService)
        {
            vacationsService = _vacationsService;
        }

        [HttpPost]
        [Route("Vacations_Get")]
        [ProducesResponseType(typeof(List<Vacations>), StatusCodes.Status200OK)]
        public List<Vacations> Vacations_Get(Vacations vacations)
        {
            return vacationsService.Vacations_Get(vacations);
        }

        [HttpPost]
        [Route("Vacations_Insert")]
        [ProducesResponseType(typeof(Clinics), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Vacations_Insert([FromBody] Vacations vacations)
        {
            return vacationsService.Vacations_Insert(vacations);
        }

        [HttpPut]
        [Route("Vacations_Update")]
        [ProducesResponseType(typeof(List<Clinics>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Vacations_Update([FromBody] Vacations vacations)
        { 
            return vacationsService.Vacations_Update(vacations);
        }

        [HttpDelete]
        [Route("Vacations_Delete/{id}")]
        public bool Vacations_Delete(int id)
        {
            return vacationsService.Vacations_Delete(id);
        }
    }
}
