using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using MtG_Decktester.Data;

namespace MtG_Decktester.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MtG_DecktesterContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MtG_DecktesterContext>>()))
            {
                context.Database.Migrate(); // Creates database if not exist
            }
        }
    }
}