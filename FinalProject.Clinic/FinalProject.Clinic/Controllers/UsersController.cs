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
    [Route("[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;
        public UsersController(IUsersService usersService) 
        {
            this.usersService = usersService;
        }

        [HttpPost]
        [Route("Users_Insert")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        public bool Users_Insert([FromBody] Users users)
        {
            return usersService.Users_Insert(users);
        }

        [HttpPost]
        [Route("Users_Get")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]

        public List<Users> Users_Get(Users users)
        {
            return usersService.Users_Get(users);
        }

        [HttpPut]
        [Route("Users_Update")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Users_Update([FromBody] Users users)
        {
            return usersService.Users_Update(users);
        }
        [HttpDelete]
        [Route("Users_Delete")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Users_Delete(int id)
        {
            return usersService.Users_Delete(id);
        }

        [HttpPost]
        [Route("Login")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Authentication([FromBody] Users login)
        {
            var token = usersService.Authentication(login);

            if (token == null)
                return Unauthorized();
            else
                return Ok(token);

        }

        [HttpPut]
        [Route("Users_UpdatePassword")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Users_UpdatePassword([FromBody]UsersUpdatePasswordDTO users)
        {
            return usersService.Users_UpdatePassword(users);
        }
    }
}
