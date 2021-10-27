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
    public class ClinicCategoryController : ControllerBase
    {
        private readonly IClinicCategoryService clinicCategoryService;
        public ClinicCategoryController(IClinicCategoryService _cliniccategoryService)
        {
            clinicCategoryService = _cliniccategoryService;
        }

        [HttpGet]
        [Route("ClinicCategory_Get/{id}")]
        [ProducesResponseType(typeof(List<ClinicCategory>), StatusCodes.Status200OK)]
        public List<ClinicCategory> ClinicCategory_Get(int? id)
        {
            return clinicCategoryService.ClinicCategory_Get(id);
        }

        [HttpPost]
        [Route("ClinicCategory_Insert")]
        [ProducesResponseType(typeof(ClinicCategory), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool ClinicCategory_Insert([FromBody] ClinicCategory clinicCategory)
        {
            return clinicCategoryService.ClinicCategory_Insert(clinicCategory);
        }

        [HttpPut]
        [Route("ClinicCategory_Update")]
        [ProducesResponseType(typeof(List<ClinicCategory>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool ClinicCategory_Update([FromBody] ClinicCategory clinicCategory)
        {
            return clinicCategoryService.ClinicCategory_Update(clinicCategory);
        }

        [HttpDelete]
        [Route("ClinicCategory_Delete/{id}")]
        [ProducesResponseType(typeof(ClinicCategory), StatusCodes.Status200OK)]
        public bool ClinicCategory_Delete(int id)
        {
            return clinicCategoryService.ClinicCategory_Delete(id);
        }

    }
}
