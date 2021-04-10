using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BYUArchaeologyEgypt.Areas.Identity.Data;
using BYUArchaeologyEgypt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BYUArchaeologyEgypt.Models
{
        public class BurialContext : IdentityDbContext<BYUArchaeologyEgyptUser>
        {
            public BurialContext(DbContextOptions<BurialContext> options) : base(options)
            {
            }
            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                // Customize the ASP.NET Identity model and override the defaults if needed.
                // For example, you can rename the ASP.NET Identity table names and more.
                // Add your customizations after calling base.OnModelCreating(builder);
            }
            public DbSet<Burial> Burials { get; set; }
            public DbSet<Location> Locations { get; set; }
            public DbSet<FileOnFileSystemModel> FileOnFileSystemModels { get; set; }
            public DbSet<BiologicalSample> BiologicalSamples { get; set; }
        }
}
