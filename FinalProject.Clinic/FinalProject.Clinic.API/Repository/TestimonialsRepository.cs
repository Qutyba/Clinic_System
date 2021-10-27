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
    public class TestimonialsRepository: ITestimonialsRepository
    {
        private readonly IDbContext dbContext;
        public TestimonialsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Testimonials> Testimonials_Get(int? SiteID)
        {
            DynamicParameters p = new DynamicParameters();
            if(SiteID != null)
                p.Add("@SiteID", SiteID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Testimonials> result = dbContext.Connection.Query<Testimonials>("Testimonials_Get",p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Testimonials_Activate(int testimonialID)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@TestimonialID", testimonialID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            bool result = dbContext.Connection.ExecuteAsync("Testimonials_Activate", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }

        public bool Testimonials_Delete(int testimonialID)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@TestimonialID", testimonialID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            bool result = dbContext.Connection.ExecuteAsync("Testimonials_Delete", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }


        public bool Testimonials_Insert(Testimonials oTestimonials)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@PatientID", oTestimonials.PatientId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Title", oTestimonials.Title, dbType: DbType.String, direction: ParameterDirection.Input,100);
            p.Add("@Description", oTestimonials.Description, dbType: DbType.String, direction: ParameterDirection.Input,100);
            p.Add("@TestimonialDate", DateTime.Now, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@SiteID", oTestimonials.SiteId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            bool result = dbContext.Connection.ExecuteAsync("Testimonials_Insert", p, commandType: CommandType.StoredProcedure).Result > 0;
            return result;
        }
    }
}
