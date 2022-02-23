using HoliDayRental.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental
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
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });      //permet de configurer les sessions pour mon application

            services.AddControllersWithViews();

            
            //service bien
            services.AddScoped<HoliDayRental.Common.Repository.IBienEchangeRepository<HoliDayRental.DAL.Entite.BienEchange>, HoliDayRental.DAL.Repository.BienEchangeService>();
            services.AddScoped<HoliDayRental.Common.Repository.IBienEchangeRepository<HoliDayRental.BLL.Entity.BienEchange>, HoliDayRental.BLL.Service.BienEchangeService>();

            //service membre
            services.AddScoped<HoliDayRental.Common.Repository.IMembreRepository<HoliDayRental.BLL.Entity.Membre>, HoliDayRental.BLL.Service.MembreService>();
            services.AddScoped<HoliDayRental.Common.Repository.IMembreRepository<HoliDayRental.DAL.Entite.Membre>,  HoliDayRental.DAL.Repository.MembreService>();

            //service pays
            services.AddScoped<HoliDayRental.Common.Repository.IMembreRepository<HoliDayRental.BLL.Entity.Pays>, HoliDayRental.BLL.Service.>();
            services.AddScoped<HoliDayRental.Common.Repository.IMembreRepository<HoliDayRental.DAL.Entite.Pays>, HoliDayRental.DAL.Repository.PaysService>();

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseSession(); //Permet d'utiliser le middlewate session pour notre application
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
