using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Service
{
  public  interface IVacationsService
    {
        List<Vacations> Vacations_Get(Vacations vacations);
        bool Vacations_Insert(Vacations vacations);
        bool Vacations_Update(Vacations vacations);
        bool Vacations_Delete(int id);
    }
}
