using FinalProject.Clinic.Core.Common;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using FinalProject.Clinic.Infra.Common;
using FinalProject.Clinic.Infra.Repository;
using FinalProject.Clinic.Infra.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Clinic
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("x",builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
        });

            services.AddControllers();
            services.AddScoped<IDbContext, DbContext>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IRolesRepository, RolesRepository>();
            services.AddScoped<IRolesService, RolesService>(); 
            services.AddScoped<IDaysRepository, DaysRepository>();
            services.AddScoped<IDaysService, DaysService>();
            services.AddScoped<IReservationsRepository, ReservationsRepository>();
            services.AddScoped<IReservationsService, ReservationsService>();


            services.AddScoped<IWorkingHoursRepository, WorkingHoursRepository>();
            services.AddScoped<IWorkingHoursService, WorkingHoursService>();


            services.AddScoped<ISiteSettingsRepository, SiteSettingsRepository>();
            services.AddScoped<ISiteSettingsService, SiteSettingsService>();
            services.AddScoped<IContactUsRepository, ContactUsRepository>();
            services.AddScoped<IContactUsService, ContactUsService>();
            services.AddScoped<IReviewsRepository, ReviewsRepository>();
            services.AddScoped<IReviewsService, ReviewsService>();
            services.AddScoped<ITestimonialsRepository, TestimonialsRepository>();
            services.AddScoped<ITestimonialsService, TestimonialsService>();

            services.AddScoped<IClinicsRepository, ClinicsRepository>();
            services.AddScoped<IClinicsService, ClinicsService>();
            services.AddScoped<IClinicCategoryRepository, ClinicCategoryRepository>();
            services.AddScoped<IClinicCategoryService, ClinicCategoryService>();
            services.AddScoped<IVacationsRepository, VacationsRepository>();
            services.AddScoped<IVacationsService, VacationsService>();

            //for authentication
            services.AddAuthentication(
                          x =>
                          {
                              x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                              x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                          }
                      ).AddJwtBearer(
                          y =>
                          {
                              y.RequireHttpsMetadata = false;
                              y.SaveToken = true;
                              y.TokenValidationParameters = new TokenValidationParameters
                              {
                                  ValidateIssuerSigningKey = true,
                                  IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOEKN, IT CAN BE ANY STRING]")),
                                  ValidateIssuer = false,
                                  ValidateAudience = false
                              };
                          }

                      );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("x");
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
