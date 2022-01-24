using AutoMapper;
using BL;
using DL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApiSite
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
            services.AddScoped<IMassageBL,MassageBL>();
            services.AddScoped<IMassageDL,MassageDL>();
            services.AddScoped<IVisitBL, VisitBL>();
            services.AddScoped<IVisitDL, VisitDL>();
            services.AddScoped<IGroupBL, GroupBL>();
            services.AddScoped<IGroupDL, GroupDL>();
            services.AddScoped<IRaiseBL, RaiseBL>();
            services.AddScoped<IRaiseDL, RaiseDL>();
            services.AddScoped<IDonorBL, DonorBL>();
            services.AddScoped<IDonorDL, DonorDL>();
            services.AddScoped< IManagerBL, ManagerBL>();
            services.AddScoped<IManagerDL, ManagerDL>();
            services.AddScoped<IRatingBL, RatingBL>();
            services.AddScoped<IRatingDL, RatingDL>();


            services.AddControllers();

            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<DonationManagementContext>(options => options.UseSqlServer(
              Configuration.GetConnectionString("DonationManagement")), ServiceLifetime.Scoped);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyFirstWebApiSite", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            app.UseErrorsMiddleWare();
            app.UseCacheMiddleWare();
       
          app.UseRatingMiddleWare();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyFirstWebApiSite v1"));
            }
            app.UseHttpsRedirection();
  
            app.UseRouting();
            
            app.Map("/api", app2 =>
            {
                app2.UseRouting();
               // app2.UseRatingMiddleware();
                app2.UseAuthorization();

                app2.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            });

            //app.UseHttpsRedirection();

            //app.UseRouting();
            //app.UseStaticFiles();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            logger.LogInformation("logger-startup");
            logger.LogError("logger-mail-startup");
        }
    }
}
