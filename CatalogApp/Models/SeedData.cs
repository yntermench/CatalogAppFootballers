using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicatonContext context = 
                services.GetRequiredService<ApplicatonContext>();
            context.Migrate();

            if (!context.Footballers.Any())
            {
                context.Footballers.AddRange(
                    new Footballer
                    {
                        Name = "",
                        Gender = true,
                        DateBirth = new DateTime(),
                        Surname = "",
                        NameCommand = "",
                        Country = "Россия"
                    },
                    new Footballer
                    {
                        Name = "",
                        Gender = true,
                        DateBirth = new DateTime(),
                        Surname = "",
                        NameCommand = "",
                        Country = "США"
                    },
                    new Footballer
                    {
                        Name = "",
                        Gender = true,
                        DateBirth = new DateTime(),
                        Surname = "",
                        NameCommand = "",
                        Country = "Италия"
                    }
                    );
            }
        }
    }
}
