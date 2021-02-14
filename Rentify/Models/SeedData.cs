using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rentify.Data;
using Rentify.Models;
using System;
using System.Linq;

namespace Rentify.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyDBContext>>()))
            {
                // Look for any movies.
                if (context.Peliculas.Any())
                {
                    return;   // DB has been seeded
                }

                context.Peliculas.AddRange(
                    new Pelicula
                    {
                        Nombre = "When Harry Met Sally"
                        //Title = "When Harry Met Sally",
                        //ReleaseDate = DateTime.Parse("1989-2-12"),
                        //Genre = "Romantic Comedy",
                        //Price = 7.99M
                    },

                    new Pelicula
                    {
                        Nombre = "Cazafantasmas"
                        //Title = "Ghostbusters ",
                        //ReleaseDate = DateTime.Parse("1984-3-13"),
                        //Genre = "Comedy",
                        //Price = 8.99M
                    },

                    new Pelicula
                    {
                        Nombre = "Cazfantasmas 2"
                        //Title = "Ghostbusters 2",
                        //ReleaseDate = DateTime.Parse("1986-2-23"),
                        //Genre = "Comedy",
                        //Price = 9.99M
                    },

                    new Pelicula
                    {
                        Nombre = "Rio Bravo"
                        //Title = "Rio Bravo",
                        //ReleaseDate = DateTime.Parse("1959-4-15"),
                        //Genre = "Western",
                        //Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}