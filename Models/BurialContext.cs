using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BYUArchaeologyEgypt.Models;
using Microsoft.EntityFrameworkCore;

namespace BYUArchaeologyEgypt.Models
{
        public class BurialContext : DbContext
        {
            public BurialContext(DbContextOptions<BurialContext> options) : base(options)
            {

            }

            public DbSet<Burial> Burials { get; set; }
            public DbSet<Location> Locations { get; set; }
            public DbSet<AgeAtDeath> AgesAtDeath { get; set; }
            public DbSet<BurialWrapping> BurialWrappings { get; set; }
            public DbSet<HairColor> HairColors { get; set; }
            public DbSet<Sex> Sexes { get; set; }
        }
}
