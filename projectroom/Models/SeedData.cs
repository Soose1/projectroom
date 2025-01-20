using Microsoft.EntityFrameworkCore;
using projectroom.Data;

namespace projectroom.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new projectroomContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<projectroomContext>>()))
            {
                // Look for any projects.
                if (context.Project.Any())
                {
                    return;   // DB has been seeded
                }
                context.Project.AddRange(
                    new Project
                    {
                        Title = "Auto666",
                        ReleaseDate = DateTime.Parse("2022-2-12"),
                        Type = "WebApp",
                        Price = 1.99M
                    },
                    new Project
                    {
                        Title = "Serene Beauty",
                        ReleaseDate = DateTime.Parse("2023-3-13"),
                        Type = "WebApp",
                        Price = 0.99M
                    },
                    new Project
                    {
                        Title = "Panchoho",
                        ReleaseDate = DateTime.Parse("2023-2-23"),
                        Type = "WebSite",
                        Price = 0.99M
                    },
                    new Project
                    {
                        Title = "RonaldoTuning",
                        ReleaseDate = DateTime.Parse("2024-4-15"),
                        Type = "WebApp",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
