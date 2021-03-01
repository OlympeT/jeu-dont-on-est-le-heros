using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace jeudontonestleheros.Web.UI
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
            services.AddControllersWithViews();

            // Configuration de la connection au server sql
            string connectionString = this.Configuration.GetConnectionString("DefaultContext");

            // Etablir la connection
            services.AddDbContext<DefaultContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

            services.AddAuthentication().AddFacebook(options =>
            {
                options.AppId = this.Configuration["apis:facebook:appid"];
                options.AppSecret = this.Configuration["apis:facebook:secret"];
                options.AccessDeniedPath = "/AccessDeniedPathInfo";
                options.CallbackPath = "/Identity/Account/ExternalLogin";
            });
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "mesaventure",
                    pattern: "mes-aventures",
                    defaults: new
                    {
                        controller = "Aventure",
                        action = "Index"
                    });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
