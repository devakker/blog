using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using blog.Data;
using blog.Models;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        private const string LoremIpsum = @"Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Post.Any())
                {
                    return;   // DB has been seeded
                }

                context.Post.AddRange(
                    new Post
                    {
                        Title = "Some post",
                        LastEdited = DateTime.Parse("2019-2-12"),
                        Preview = "Couple of words about this some post",
                        Body = String.Join(Environment.NewLine, Enumerable.Repeat(LoremIpsum, 4))
            },

                    new Post
                    {
                        Title = "Another post",
                        LastEdited = DateTime.Parse("2019-3-13"),
                        Preview = "Couple of words about this another post",
                        Body = String.Join(Environment.NewLine, Enumerable.Repeat(LoremIpsum, 3))
                    },

                    new Post
                    {
                        Title = "Long post",
                        LastEdited = DateTime.Parse("2019-2-23"),
                        Preview = "Couple of words about this long post",
                        Body = String.Join(Environment.NewLine, Enumerable.Repeat(LoremIpsum, 7))
                    },

                    new Post
                    {
                        Title = "Short post",
                        LastEdited = DateTime.Parse("2019-4-15"),
                        Preview = "Couple of words about this short post",
                        Body = String.Join(Environment.NewLine, Enumerable.Repeat(LoremIpsum, 2))
                    }
                );
                context.SaveChanges();
            }
        }
    }
}