using Microsoft.EntityFrameworkCore;

namespace ASP_NetProject.Models;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }
        //TODO Her skal ein relation gerast -!
        //public DbSet<Product> Products => Set<Product>();
}