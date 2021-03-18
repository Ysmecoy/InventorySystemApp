using System;
using InventorySystemApp.Areas.Identity.Data;
using InventorySystemApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(InventorySystemApp.Areas.Identity.IdentityHostingStartup))]
namespace InventorySystemApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<InventorySystemAppDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("InventorySystemAppDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<InventorySystemAppDbContext>();
            });
        }
    }
}