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
    public class ClinicsRepository : IClinicsRepository
    {
        private readonly IDbContext DbContext;
        public ClinicsRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public List<Clinics> Clinics_Get(Clinics clinics)
        {
            var p = new DynamicParameters();
            p.Add("@ClinicName", clinics.ClinicName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ManagerID", clinics.ManagerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CategoryID", clinics.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Longitude", clinics.Longitude, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Latitude", clinics.Latitude, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Clinics> result = DbContext.Connection.Query<Clinics>("Clinics_Get",p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Clinics_Insert(Clinics clinics)
        {
            var p = new DynamicParameters();
            p.Add("@ClinicName", clinics.ClinicName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ManagerID", clinics.ManagerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CategoryID", clinics.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Longitude", clinics.Longitude, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Latitude", clinics.Latitude, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Logo", clinics.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Citye", clinics.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Street", clinics.Street, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Building", clinics.Building, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Floor", clinics.Floor, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ApartmentNumber", clinics.ApartmentNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ClinicDescription ", clinics.ClinicDescription, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DoctorsList", clinics.DoctorsList, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ReservationTimeSlot", clinics.ReservationTimeSlot, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@TelNumber", clinics.TelNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MobileNumber", clinics.MobileNumber, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("Clinics_Insert", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

        public bool Clinics_Update(Clinics clinics)
        {
            var p = new DynamicParameters();
            p.Add("@ClinicID", clinics.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ClinicName", clinics.ClinicName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ManagerID", clinics.ManagerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CategoryID", clinics.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Logo", clinics.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Citye", clinics.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Street", clinics.Street, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Building", clinics.Building, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Floor", clinics.Floor, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ApartmentNumber", clinics.ApartmentNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Longitude", clinics.Longitude, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Latitude", clinics.Latitude, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ClinicDescription ", clinics.ClinicDescription, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DoctorsList", clinics.DoctorsList, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ReservationTimeSlot", clinics.ReservationTimeSlot, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@TelNumber", clinics.TelNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MobileNumber", clinics.MobileNumber, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("Clinics_Update", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

        public bool Clinics_Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@ClinicID", id, dbType: DbType.Int32, direction:
            ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Clinics_Delete", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

    }
}
