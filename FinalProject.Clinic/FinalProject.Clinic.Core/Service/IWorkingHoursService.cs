using FinalProject.Clinic.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Service
{
    public interface IWorkingHoursService
    {
        bool WorkingHours_Update(WorkingHours workingHours);
        bool WorkingHours_Insert(WorkingHours workingHours);
        bool WorkingHours_Delete(int id);
        List<WorkingHours> WorkingHours_Get(WorkingHours workingHours);
    }
}
