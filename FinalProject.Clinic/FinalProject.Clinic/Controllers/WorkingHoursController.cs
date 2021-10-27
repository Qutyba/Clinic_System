using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Clinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkingHoursController : Controller 
    {
        public readonly IWorkingHoursService workingHoursService;

        public WorkingHoursController(IWorkingHoursService workingHoursService) 
        {
            this.workingHoursService = workingHoursService;
        }

        [HttpDelete]
        [Route("WorkingHours_Delete/{id}")]
        [ProducesResponseType(typeof(WorkingHours), StatusCodes.Status200OK)]
        public bool WorkingHours_Delete(int id)
        {
            return this.workingHoursService.WorkingHours_Delete(id);
        }
        [HttpPost]
        [Route("WorkingHours_Get")]
        [ProducesResponseType(typeof(List<WorkingHours>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<WorkingHours> WorkingHours_Get(WorkingHours workingHours)
        {
            return this.workingHoursService.WorkingHours_Get(workingHours);
        }

        [HttpPost]
        [ProducesResponseType(typeof(WorkingHours), StatusCodes.Status200OK)]
        [Route("WorkingHours_Insert")]
        public bool WorkingHours_Insert(WorkingHours workingHours)
        {
            return this.workingHoursService.WorkingHours_Insert(workingHours);
        }



        [HttpPut]
        [Route("WorkingHours_Update")]
        [ProducesResponseType(typeof(WorkingHours), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool WorkingHours_Update(WorkingHours workingHours)
        {
            return this.workingHoursService.WorkingHours_Update(workingHours);
        }





    }
}
