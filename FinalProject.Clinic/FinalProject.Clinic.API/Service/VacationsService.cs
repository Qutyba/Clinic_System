using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Infra.Service
{
    public class VacationsService : IVacationsService
    {
        private readonly IVacationsRepository vacations_Repository;
        public VacationsService(IVacationsRepository _vacations_Repository)
        {
            vacations_Repository = _vacations_Repository;
        }


        public List<Vacations> Vacations_Get(Vacations vacations)
        {
            return vacations_Repository.Vacations_Get(vacations);
        }
        public bool Vacations_Insert(Vacations vacations)
        {
            return vacations_Repository.Vacations_Insert(vacations);
        }

        public bool Vacations_Update(Vacations vacations)
        {
            return vacations_Repository.Vacations_Update(vacations);
        }
        public bool Vacations_Delete(int id)
        {
            return vacations_Repository.Vacations_Delete(id);
        }
    }
}
