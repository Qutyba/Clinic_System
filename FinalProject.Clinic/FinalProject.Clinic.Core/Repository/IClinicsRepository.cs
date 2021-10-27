using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Repository
{
   public interface IClinicsRepository
    {
        List<Clinics> Clinics_Get(Clinics clinics);
        bool Clinics_Insert(Clinics clinics);
        bool Clinics_Update(Clinics clinics);
        bool Clinics_Delete(int id);
    }
}
