using Dapper;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Common;
using FinalProject.Clinic.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Clinic.Infra.Repository
{
    public class VacationsRepository : IVacationsRepository
    {
        private readonly IDbContext DbContext;
        public VacationsRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public List<Vacations> Vacations_Get(Vacations vacations)
        {
            var p = new DynamicParameters();
            p.Add("@ClinicID", vacations.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@StartDate", vacations.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", vacations.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            IEnumerable<Vacations> result = DbContext.Connection.Query<Vacations>("Vacations_Get", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Vacations_Insert(Vacations vacations)
        {
            var p = new DynamicParameters();
            p.Add("@ClinicID", vacations.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@StartDate", vacations.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", vacations.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Description", vacations.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Vacations_Insert", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

        public bool Vacations_Update(Vacations vacations)
        {
            var p = new DynamicParameters();
            p.Add("@VacationID", vacations.VacationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ClinicID", vacations.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@StartDate", vacations.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", vacations.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Description", vacations.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Vacations_Update", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

        public bool Vacations_Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@VacationID", id, dbType: DbType.Int32, direction:
            ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Vacations_Delete", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

    }
}
