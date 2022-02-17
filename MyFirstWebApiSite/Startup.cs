using AutoMapper;
using BL;
using DL;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", p =>
                {
                    p.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });

            });
            var key = Encoding.ASCII.GetBytes(Configuration.GetSection("key").Value);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {

                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            services.AddScoped<IMassageBL, MassageBL>();
            services.AddScoped<IMassageDL, MassageDL>();
            services.AddScoped<IVisitBL, VisitBL>();
            services.AddScoped<IVisitDL, VisitDL>();
            services.AddScoped<IGroupBL, GroupBL>();
            services.AddScoped<IGroupDL, GroupDL>();
            services.AddScoped<IRaiseBL, RaiseBL>();
            services.AddScoped<IRaiseDL, RaiseDL>();
            services.AddScoped<IDonorBL, DonorBL>();
            services.AddScoped<IDonorDL, DonorDL>();
            services.AddScoped<IManagerBL, ManagerBL>();
            services.AddScoped<IManagerDL, ManagerDL>();
            services.AddScoped<IRatingBL, RatingBL>();
            services.AddScoped<IRatingDL, RatingDL>();


            //services.AddControllers();

            services.AddControllers().AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNameCaseInsensitive = false);

            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<DonationManagementContext>(options => options.UseSqlServer(
              Configuration.GetConnectionString("DonationManagement")), ServiceLifetime.Scoped);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyFirstWebApiSite", Version = "v1" });
                // To Enable authorization using Swagger (JWT)    
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Enter 'Bearer' [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });


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
            app.UseCors("AllowAll");

            

            app.UseRouting();


            //app.Map("/api", app2 =>
            //{
            //    app2.UseRouting();
            //    app2.UseRatingMiddleWare();
            //    app2.UseAuthorization();

            //    app2.UseEndpoints(endpoints =>
            //    {
            //        endpoints.MapControllers();
            //    });
            //});


            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseAuthorization();




            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            logger.LogInformation("logger-startup");

        }
    }
}
