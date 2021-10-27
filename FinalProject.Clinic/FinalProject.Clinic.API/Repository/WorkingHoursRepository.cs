using Dapper;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Common;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Clinic.Infra.Repository
{
   public  class WorkingHoursRepository: IWorkingHoursRepository
    {
        private readonly IDbContext dbContext;
        public WorkingHoursRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool WorkingHours_Update(WorkingHours workingHours)
        {
            var p = new DynamicParameters();

            p.Add("@WorkingHoursId", workingHours.WorkingHoursId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@WorkingFrom", workingHours.WorkingFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@WorkingTo", workingHours.WorkingTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@BreakFrom", workingHours.BreakFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@BreakTo", workingHours.BreakTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);


            var result = dbContext.Connection.ExecuteAsync("WorkingHours_Update", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

        public bool WorkingHours_Insert(WorkingHours workingHours)
        {
            var p = new DynamicParameters();
            p.Add("@ClinicId", workingHours.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@DayId", workingHours.DayId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@WorkingFrom", workingHours.WorkingFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@WorkingTo", workingHours.WorkingTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@BreakFrom", workingHours.BreakFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@BreakTo", workingHours.BreakTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("WorkingHours_Insert", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

        public bool WorkingHours_Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@WorkingHoursID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("WorkingHours_Delete", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

        public List<WorkingHours> WorkingHours_Get(WorkingHours workingHours)
        {
            var p = new DynamicParameters();

            p.Add("@ClinicID", workingHours.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@WorkingHoursID", workingHours.WorkingHoursId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@DayID", workingHours.DayId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<WorkingHours> result = dbContext.Connection.Query<WorkingHours>("WorkingHours_Get", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

     

    }
}
