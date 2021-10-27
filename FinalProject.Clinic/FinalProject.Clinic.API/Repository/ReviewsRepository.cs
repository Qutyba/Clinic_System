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
    public class ReviewsRepository: IReviewsRepository
    {
        private readonly IDbContext dbContext;
        public ReviewsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Reviews> Reviews_Get(int? SiteID)
        {
            DynamicParameters p = new DynamicParameters();
            if (SiteID != null)
                p.Add("@SiteID", SiteID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Reviews> result = dbContext.Connection.Query<Reviews>("Reviews_Get", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Reviews_Delete(int reviewID)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ReviewID", reviewID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            bool result = dbContext.Connection.ExecuteAsync("Reviews_Delete", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }


        public bool Reviews_Insert(Reviews oReviews)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@Rate", oReviews.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ReviewDate", DateTime.Now, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@SiteID", oReviews.SiteId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            bool result = dbContext.Connection.ExecuteAsync("Reviews_Insert", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }
    }
}
