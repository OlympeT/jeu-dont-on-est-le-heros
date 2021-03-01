using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestAuthentification001.Areas.Identity.Data;

[assembly: HostingStartup(typeof(TestAuthentification001.Areas.Identity.IdentityHostingStartup))]
namespace TestAuthentification001.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TestAuthentification001IdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TestAuthentification001IdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TestAuthentification001IdentityDbContext>();
            });
        }
    }
}