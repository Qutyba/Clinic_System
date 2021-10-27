using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Infra.Service
{
    public class ClinicCategoryService : IClinicCategoryService
    {
        private readonly IClinicCategoryRepository cliniccategory_Repository;
        public ClinicCategoryService(IClinicCategoryRepository _cliniccategory_Repository)
        {
            cliniccategory_Repository = _cliniccategory_Repository;
        }
        public List<ClinicCategory> ClinicCategory_Get(int? id)
        {
            return cliniccategory_Repository.ClinicCategory_Get(id);
        }

        public bool ClinicCategory_Insert(ClinicCategory cliniccategory)
        {
            return cliniccategory_Repository.ClinicCategory_Insert(cliniccategory);
        }

        public bool ClinicCategory_Update(ClinicCategory cliniccategory)
        {
            return cliniccategory_Repository.ClinicCategory_Update(cliniccategory);
        }

        public bool ClinicCategory_Delete(int id)
        {
            return cliniccategory_Repository.ClinicCategory_Delete(id);
        }
    }
}
