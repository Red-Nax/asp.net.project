using Microsoft.EntityFrameworkCore;

namespace GroupProject.Models;

public class ToDoDbContext : DbContext
{
    public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options) { }
        public DbSet<User> Users => Set<User>();
        public DbSet<ToDo> ToDos => Set<ToDo>();
}