using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BurialContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BurialContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            /*
            if (!context.Sexes.Any())
            {
                context.Sexes.AddRange(
                    new Sex { SexDescription = "Male" },
                    new Sex { SexDescription = "Female" },
                    new Sex { SexDescription = "Unknown" }
                );
            }
            if (!context.HairColors.Any())
            {
                context.HairColors.AddRange(
                    new HairColor { HairColorDescription = "Brown" },
                    new HairColor { HairColorDescription = "Black" },
                    new HairColor { HairColorDescription = "Brown-red" },
                    new HairColor { HairColorDescription = "Red" },
                    new HairColor { HairColorDescription = "Blond" },
                    new HairColor { HairColorDescription = "Unknown" }
                );
            }
            if (!context.BurialWrappings.Any())
            {
                context.BurialWrappings.AddRange(
                    new BurialWrapping { BurialWrappingDescription = "Full or nearly full wrapping remains" },
                    new BurialWrapping { BurialWrappingDescription = "Partial wrapping remain" },
                    new BurialWrapping { BurialWrappingDescription = "Bones and/or only partial remnants of wrapping remains" },
                    new BurialWrapping { BurialWrappingDescription = "Unknown" }
                );
            }
            if (!context.AgesAtDeath.Any())
            {
                context.AgesAtDeath.AddRange(
                    new AgeAtDeath { AgeDescription = "Adult" },
                    new AgeAtDeath { AgeDescription = "Child" },
                    new AgeAtDeath { AgeDescription = "Infant" },
                    new AgeAtDeath { AgeDescription = "Newborn" },
                    new AgeAtDeath { AgeDescription = "Unknown" }
                );
            }*/
        }
    }
}
