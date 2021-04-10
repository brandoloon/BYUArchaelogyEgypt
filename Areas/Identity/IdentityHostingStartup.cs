using System;
using BYUArchaeologyEgypt.Areas.Identity.Data;
using BYUArchaeologyEgypt.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BYUArchaeologyEgypt.Areas.Identity.IdentityHostingStartup))]
namespace BYUArchaeologyEgypt.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {

                services.AddDefaultIdentity<BYUArchaeologyEgyptUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<BurialContext>();
            });
        }
    }
}