using Microsoft.EntityFrameworkCore;

namespace GroupProject.Models;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }
        public DbSet<User> Users => Set<User>();
        public DbSet<ToDo> ToDos => Set<ToDo>();
}