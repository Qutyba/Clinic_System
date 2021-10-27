using System.Collections.Generic;
using FinalProject.Clinic.Core.DTO;

namespace FinalProject.Clinic.Core.Service
{
    public interface IReservationsService
    {
        bool Reservation_Insert(Reservations reservations);
        bool Reservation_Delete(int id);
        List<Reservations> Reservation_Get(Reservations reservations);
    }
}