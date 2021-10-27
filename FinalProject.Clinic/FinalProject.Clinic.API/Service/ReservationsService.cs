using System;
using System.Collections.Generic;
using System.Text;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;

namespace FinalProject.Clinic.Infra.Service
{
   public class ReservationsService :IReservationsService
   {
       public readonly IReservationsRepository reservationsRepository;

       public ReservationsService(IReservationsRepository reservationsRepository)
       {
           this.reservationsRepository = reservationsRepository;
       }

       public bool Reservation_Insert(Reservations reservations)
       {
          return this.reservationsRepository.Reservation_Insert(reservations);
       }

        public bool Reservation_Delete(int id)
        {
            return this.reservationsRepository.Reservation_Delete(id);
        }

        public List<Reservations> Reservation_Get(Reservations reservations)
        {
            return this.reservationsRepository.Reservation_Get(reservations);
        }
    }
}
