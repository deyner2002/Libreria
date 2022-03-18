using CleanArchitecture.Domain;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context, ILogger<ApplicationDbContextSeed> logger)
        {
            if (!context.Autores!.Any())
            {
                context.Autores!.AddRange(GetPreconfiguredAutor());
                await context.SaveChangesAsync();
                logger.LogInformation("Estamos insertando nuevos records al bd {context}",typeof(ApplicationDbContext).Name);
            }
        }

        private static IEnumerable<Autor> GetPreconfiguredAutor()
        {
            return new List<Autor>
            {
                new Autor { CreatedBy= "DeynerSystem", Nombre= "Gabriel Garcia Marquez"},
                new Autor { CreatedBy= "DeynerSystem", Nombre= "Alberto Linero"}
            };
        }
    }
}
