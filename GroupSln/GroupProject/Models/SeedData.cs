using GroupProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_NetProject.Models;

public static class SeedData
{
    public static void EnsurePopulated(IApplicationBuilder app)
    {
        ToDoDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<ToDoDbContext>();
        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }

        if (!context.Users.Any())
        {
            context.Users.AddRange(
                new User { Username = "Admin", Password = "1234" }
            );

            context.SaveChanges();
        }
        
        if (!context.ToDos.Any())
        {
            context.ToDos.AddRange(
                new ToDo { CreatorOfTask = "Alex", Description = "Støvsugva", StartTime = DateTime.Now, EndTime = DateTime.Now, TaskTitle = "title", UserId = 2}
            );

            context.SaveChanges();
        }

      
    }
}