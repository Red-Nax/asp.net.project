using Microsoft.EntityFrameworkCore;

namespace ASP_NetProject.Models;

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

        if (!context.Users.Any())
        {
            context.Users.AddRange(
                new User { Name = "Admin", Password = "1234", UserID = "1" },
                new User {Name = "AlexErEinPleb", Password = "1934", UserID = "0 tí hann er eitt 0"}
            );

            context.SaveChanges();
        }
    }
}