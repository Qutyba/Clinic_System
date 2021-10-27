using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Common;
using FinalProject.Clinic.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Linq;
using System.Data;

namespace FinalProject.Clinic.Infra.Repository
{
    public class SiteSettingsRepository: ISiteSettingsRepository
    {
        private readonly IDbContext dbContext;
        public SiteSettingsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public SiteSettings SiteSettings_Get(int? SiteID)
        {
            DynamicParameters p = new DynamicParameters();
            if (SiteID != null)
                p.Add("@SiteID", SiteID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            SiteSettings result = dbContext.Connection.Query<SiteSettings>("SiteSettings_Get", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
            return result;
        }

        public bool SiteSettings_Update(SiteSettings oSiteSettings)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@SiteID", oSiteSettings.SiteId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@SiteLogo", oSiteSettings.SiteLogo, dbType: DbType.String, direction: ParameterDirection.Input,50);
            p.Add("@SiteName", oSiteSettings.SiteName, dbType: DbType.String, direction: ParameterDirection.Input,50);
            p.Add("@SiteDescription", oSiteSettings.SiteDescription, dbType: DbType.String, direction: ParameterDirection.Input,150);
            p.Add("@AboutUs", oSiteSettings.AboutUs, dbType: DbType.String, direction: ParameterDirection.Input,100);
            p.Add("@TelNumber", oSiteSettings.TelNumber, dbType: DbType.String, direction: ParameterDirection.Input, 50);
            p.Add("@MobileNumber", oSiteSettings.MobileNumber, dbType: DbType.String, direction: ParameterDirection.Input, 50);
            p.Add("@FaxNumber", oSiteSettings.FaxNumber, dbType: DbType.String, direction: ParameterDirection.Input, 50);
            p.Add("@WhatsApp", oSiteSettings.WhatsApp, dbType: DbType.String, direction: ParameterDirection.Input, 50);
            p.Add("@FaceBook", oSiteSettings.FaceBook, dbType: DbType.String, direction: ParameterDirection.Input, 50);
            p.Add("@Twitter", oSiteSettings.Twitter, dbType: DbType.String, direction: ParameterDirection.Input, 50);
            p.Add("@LinkedIn", oSiteSettings.LinkedIn, dbType: DbType.String, direction: ParameterDirection.Input, 50);
            p.Add("@Instagram", oSiteSettings.Instagram, dbType: DbType.String, direction: ParameterDirection.Input, 50);


            bool result = dbContext.Connection.ExecuteAsync("SiteSettings_Update", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }
    }
}
