using Microsoft.EntityFrameworkCore;

namespace ASP_NetProject.Models;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }
        public DbSet<User> Users => Set<User>();
}