using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Infra.Service
{
   public class ClinicsService: IClinicsService
    {
        private readonly IClinicsRepository clinics_Repository;
        public ClinicsService(IClinicsRepository  _clinics_Repository)
        {
            clinics_Repository = _clinics_Repository;
        }

        
        public List<Clinics> Clinics_Get(Clinics clinics)
        {
            return clinics_Repository.Clinics_Get(clinics); 
        }

        public bool Clinics_Insert(Clinics clinics)
        {
            return clinics_Repository.Clinics_Insert(clinics);
        }

        public bool Clinics_Update(Clinics clinics)
        {
            return clinics_Repository.Clinics_Update(clinics);
        }

        public bool Clinics_Delete(int id)
        {
            return clinics_Repository.Clinics_Delete(id);
        }

    }
}
