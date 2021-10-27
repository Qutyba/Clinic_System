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
    public class ClinicCategoryRepository : IClinicCategoryRepository
    {
        private readonly IDbContext DbContext;
        public ClinicCategoryRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public List<ClinicCategory> ClinicCategory_Get(int? id)
        {
            var p = new DynamicParameters();
            if(id != null)
                p.Add("@CategoryID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<ClinicCategory> result = DbContext.Connection.Query<ClinicCategory>("ClinicCategory_Get",p,commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool ClinicCategory_Insert(ClinicCategory clinicCategory)
        {
            var p = new DynamicParameters();
            p.Add("@CategoryName", clinicCategory.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CategoryDescription", clinicCategory.CategoryDescription, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("ClinicCategory_Insert", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

        public bool ClinicCategory_Update(ClinicCategory cliniccategory)
        {
            var p = new DynamicParameters();
            p.Add("@CategoryID", cliniccategory.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CategoryName", cliniccategory.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CategoryDescription", cliniccategory.CategoryDescription, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("ClinicCategory_Update", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

        public bool ClinicCategory_Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CategoryID", id, dbType: DbType.Int32, direction:ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("ClinicCategory_Delete", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

    }
}
