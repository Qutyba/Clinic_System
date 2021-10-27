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
    public class RolesController : Controller
    {
        private readonly IRolesService rolesService;
        public RolesController(IRolesService rolesService) 
        {
            this.rolesService = rolesService;
        }

        [HttpGet]
        [Route("Roles_Get")]
        [ProducesResponseType(typeof(List<Roles>), StatusCodes.Status200OK)]
        public List<Roles> Roles_Get()
        {
            return rolesService.Roles_Get();
        }
    }
}
