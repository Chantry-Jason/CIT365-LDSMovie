using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The Other Side of Heaven",
                         ReleaseDate = DateTime.Parse("2001-12-14"),
                         Genre = "Drama/Adventure",
                         Rating = "PG",
                         Price = 1.99M
                     },

                     new Movie
                     {
                         Title = "The Best Two Years ",
                         ReleaseDate = DateTime.Parse("2003-1-1"),
                         Genre = "Comedy-drama/Religious",
                         Rating = "PG",
                         Price = 2.99M
                     },

                     new Movie
                     {
                         Title = "On the Way Home",
                         ReleaseDate = DateTime.Parse("1992-1-1"),
                         Genre = "Drama, Short",
                         Rating = "NR",
                         Price = 1.99M
                     },
                    new Movie
                    {
                        Title = "Come Unto Me",
                        ReleaseDate = DateTime.Parse("1986-1-1"),
                        Genre = "Drama, Short",
                        Rating = "NR",
                        Price = 1.99M
                    },
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Adventure, History",
                        Rating = "PG",
                        Price = 2.99M
                    },
                   new Movie
                   {
                       Title = "Our Heavenly Father's Plan",
                       ReleaseDate = DateTime.Parse("1986-1-1"),
                       Genre = "Short, Family",
                       Rating = "NR",
                       Price = 1.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
