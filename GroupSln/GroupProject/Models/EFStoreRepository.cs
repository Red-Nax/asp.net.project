namespace ASP_NetProject.Models;

public class EFStoreRepository : IStoreRepository
{
    private StoreDbContext _context;

    public EFStoreRepository(StoreDbContext ctx)
    {
        _context = ctx;
    }
    public IQueryable<User> Users => _context.Users;

    public void CreateUser(User u)
    {
        _context.Add(u);
        _context.SaveChanges();
    }
    
    public void DeleteUser(User u)
    {
        _context.Remove(u);
        _context.SaveChanges();
    }
    
    public void SaveUser(User u)
    {
        _context.SaveChanges();
    }
}