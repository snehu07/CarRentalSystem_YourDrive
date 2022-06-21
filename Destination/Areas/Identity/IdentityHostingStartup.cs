using System;
using Destination.Areas.Identity.Data;
using Destination.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Destination.Areas.Identity.IdentityHostingStartup))]
namespace Destination.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DestinationContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DestinationContextConnection")));

                services.AddDefaultIdentity<DestinationUser>(options => {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.SignIn.RequireConfirmedAccount = false;
                })
                    .AddEntityFrameworkStores<DestinationContext>();
            });
        }
    }
}