using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Migrantes.App.Persistencia;
using Migrantes.App.Dominio;

namespace Migrantes.App.Presentacion
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
            services.AddRazorPages();
            // services.AddDbContext<AppContext>();

            services.AddControllersWithViews();

            services.AddSingleton<IRepositorioEntidad,RepositorioEntidad>();
            services.AddSingleton<IRepositorioServicio,RepositorioServicio>();
            services.AddSingleton<IRepositorioMigrante,RepositorioMigrante>();
            services.AddSingleton<IRepositorioAmigosyfamiliares,RepositorioAmigosyfamiliares>();
            services.AddSingleton<IRepositorioNovedad,RepositorioNovedad>();
            services.AddSingleton<IRepositorioCalificacionApp,RepositorioCalificacionApp>();
            services.AddSingleton<IRepositorioCalificacionServicios,RepositorioCalificacionServicios>();
            services.AddSingleton<IRepositorioNecesidades,RepositorioNecesidades>();
            services.AddSingleton<IRepositorioEmergencia,RepositorioEmergencia>();



            // services.AddSingleton<IRepositorioPersona,RepositorioPersona>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
