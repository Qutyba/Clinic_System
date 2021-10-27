using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Repository
{
   public interface IClinicCategoryRepository
    {
        List<ClinicCategory> ClinicCategory_Get(int? id);
        bool ClinicCategory_Insert(ClinicCategory clinicCategory);
        bool ClinicCategory_Update(ClinicCategory clinicCategory);
        bool ClinicCategory_Delete(int id);
    }
}
