using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Service
{
  public interface IClinicsService
    {
        List<Clinics> Clinics_Get(Clinics clinics);
        bool Clinics_Insert(Clinics clinics);
        bool Clinics_Update(Clinics clinics);
        bool Clinics_Delete(int id);

    }
}
