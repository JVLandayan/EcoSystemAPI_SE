using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoSystemAPI.Data;
using EcoSystemAPI.Services;
using EcoSystemAPI.uow.Interfaces;
using EcoSystemAPI.uow.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;

namespace EcoSystemAPI
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
            services.AddDbContext<EcosystemContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("EcosystemAppCon")));
            //Enable Cors

            // services.AddScoped<IEcosystemRepo, MockEcosystemRepo>();
            services.AddScoped<IAccountsRepo, SqlAccountsRepo>();
            services.AddScoped<IMerchandiseRepo, SqlMerchandiseRepo>();
            services.AddScoped<ITeamsRepo, SqlTeamsRepo>();
            services.AddScoped<IArticlesRepo, SqlArticlesRepo>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.ConfigureCors();
            services.ConfigureIISIntegration();
            services.AddControllers();

            //JSON Serializer
            services.AddControllers()
                .AddNewtonsoftJson(s => {
                    s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    });
        }

           

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseCors("CorsPolicy");  

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Photos")),
                RequestPath = "/Photos"
            });
        }
    }
}
