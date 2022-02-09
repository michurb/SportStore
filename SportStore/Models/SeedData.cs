using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace SportStore.Models
{

    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kajak",
                        Description = "Jednoosobowy statek",
                        Category = "Sporty wodne",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Kamizelka ratunkowa",
                        Description = "Chroni przed zatopieniem",
                        Category = "Sporty wodne",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Piłka",
                        Description = "Do kopania",
                        Category = "Piłka nożna",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Buty",
                        Description = "Dodają szybkości",
                        Category = "Piłka nożna",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Stadiion",
                        Description = "Oferuje 35 000 miejsc",
                        Category = "Piłka nożna",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Czapka",
                        Description = "+5 do myślenia",
                        Category = "Szachy",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Zegar",
                        Description = "Odmierza czas",
                        Category = "Szachy",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Szachownica",
                        Description = "Pole bitwy",
                        Category = "Szachy",
                        Price = 75
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
