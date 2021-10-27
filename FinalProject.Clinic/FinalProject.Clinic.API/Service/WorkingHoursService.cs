using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Infra.Service
{
    public class WorkingHoursService : IWorkingHoursService
    {
        public readonly IWorkingHoursRepository workingHoursRepository;

        public WorkingHoursService(IWorkingHoursRepository workingHoursRepository) 
        {
            this.workingHoursRepository = workingHoursRepository;
        }

        public bool WorkingHours_Delete(int id)
        {
            return this.workingHoursRepository.WorkingHours_Delete(id);
        }

        public List<WorkingHours> WorkingHours_Get(WorkingHours workingHours)
        {
            return this.workingHoursRepository.WorkingHours_Get(workingHours);
        }

        public bool WorkingHours_Insert(WorkingHours workingHours)
        {
            return this.workingHoursRepository.WorkingHours_Insert(workingHours);
        }

        public bool WorkingHours_Update(WorkingHours workingHours)
        {
            return this.workingHoursRepository.WorkingHours_Update(workingHours);
        }
    }
}
