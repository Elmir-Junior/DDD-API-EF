using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WebApp.Application.Interfaces;
using WebApp.Application.Service;
using WebApp.CrossCutting;
using WebApp.CrossCutting.Mapper;
using WebApp.Infrasctructure.Repository.Repository;
using WebApp.Infrastructure.Context;
using WebApp.Infrastructure.Interfaces.Repositorys;
using WebApp.Services.Interfaces;
using WebApp.Services.Services;

namespace WebApp.ApplicationAPI
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
            services.AddControllers();


            services.AddDbContext<SQLContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SQLConnection")));
            services.AddScoped<SQLContext>();

            
            



            services.AddScoped<IRepositoryTecnologia, RepositoryTecnologia>();
            services.AddScoped<IRepositoryCandidato, RepositoryCandidato>();
            services.AddScoped<IRepositoryVaga, RepositoryVaga>();

            services.AddScoped<IServiceCandidato, ServiceCandidato>();
            services.AddScoped<IServiceTecnologia, ServiceTecnologia>();
            services.AddScoped<IServiceVaga, ServiceVaga>();

            services.AddScoped<IApplicationServiceCandidato ,ApplicationServiceCandidato>();
            services.AddScoped<IApplicationServiceTecnologia, ApplicationServiceTecnologia>();
            services.AddScoped<IApplicationServiceVaga, ApplicationServiceVaga>();


            IMapper mapper = MappingConfig.registerMaps().CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
