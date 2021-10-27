using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Service;

namespace FinalProject.Clinic.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservationsController : Controller
    {
        public readonly IReservationsService reservationsService;

        public ReservationsController(IReservationsService reservationsService)
        {

            this.reservationsService = reservationsService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Reservations), StatusCodes.Status200OK)]
        [Route("Reservation_Insert")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Reservation_Insert(Reservations reservations)
        {
            return this.reservationsService.Reservation_Insert(reservations);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        [ProducesResponseType(typeof(Reservations), StatusCodes.Status200OK)]
        public bool Reservation_Delete(int id)
        {
            return this.reservationsService.Reservation_Delete(id);
        }
        [HttpPost]
        [Route("Reservation_Get")]
        [ProducesResponseType(typeof(List<Reservations>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Reservations> Reservation_Get(Reservations reservations)
        {
            return this.reservationsService.Reservation_Get(reservations);
        }





    }
}
