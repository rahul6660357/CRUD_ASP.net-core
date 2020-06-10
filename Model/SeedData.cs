using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DempApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DempApplication.Model
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DempApplicationContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<DempApplicationContext>>()))
            {
                if(context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(new Movie
                {
                    Title = "When Harry Met Sally",
                    releaseDate = DateTime.Parse("1989-2-12"),
                    genric = "Romantic Comedy",
                    price = 7.99M
                },
                 new Movie
                 {
                     Title = "Ghostbusters ",
                     releaseDate = DateTime.Parse("1984-3-13"),
                     genric = "Comedy",
                     price = 8.99M
                 },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        releaseDate = DateTime.Parse("1986-2-23"),
                        genric = "Comedy",
                        price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        releaseDate = DateTime.Parse("1959-4-15"),
                        genric = "Western",
                        price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
