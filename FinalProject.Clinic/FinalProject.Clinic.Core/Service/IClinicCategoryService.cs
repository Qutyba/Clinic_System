using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Service
{
   public interface IClinicCategoryService
    {
        List<ClinicCategory> ClinicCategory_Get(int? id);
        bool ClinicCategory_Insert(ClinicCategory cliniccategory);
        bool ClinicCategory_Update(ClinicCategory cliniccategory);
        bool ClinicCategory_Delete(int id);
    }
}
