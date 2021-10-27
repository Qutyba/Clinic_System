using System.Collections.Generic;
using FinalProject.Clinic.Core.DTO;

namespace FinalProject.Clinic.Core.Repository
{
    public interface IReservationsRepository
    {
        bool Reservation_Insert(Reservations reservations);
        bool Reservation_Delete(int id);
        List<Reservations> Reservation_Get(Reservations reservations);

    }
}