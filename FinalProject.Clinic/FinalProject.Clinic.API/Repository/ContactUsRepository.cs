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
    public class ContactUsRepository: IContactUsRepository
    {
        private readonly IDbContext dbContext;
        public ContactUsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<ContactUs> ContactUs_Get(int? SiteID)
        {
            DynamicParameters p = new DynamicParameters();
            if (SiteID != null)
                p.Add("@SiteID", SiteID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<ContactUs> result = dbContext.Connection.Query<ContactUs>("ContactUs_Get", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool ContactUs_Delete(int contactID)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ContactID", contactID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            bool result = dbContext.Connection.ExecuteAsync("ContactUs_Delete", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }


        public bool ContactUs_Insert(ContactUs oContactUs)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ContactDate", DateTime.Now, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@SiteID", oContactUs.SiteId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ContactName", oContactUs.ContactName, dbType: DbType.String, direction: ParameterDirection.Input, 50);
            p.Add("@Email", oContactUs.Email, dbType: DbType.String, direction: ParameterDirection.Input, 50);
            p.Add("@ContactSubject", oContactUs.ContactSubject, dbType: DbType.String, direction: ParameterDirection.Input, 50);
            p.Add("@ContactMessage", oContactUs.ContactMessage, dbType: DbType.String, direction: ParameterDirection.Input, 50);

            bool result = dbContext.Connection.ExecuteAsync("ContactUs_Insert", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }
    }
}
