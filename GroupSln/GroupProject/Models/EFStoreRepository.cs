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
    
    public void DeleteUser(long id)
    {
        // IEnumerable<User> users = _context.Users.Where(x => x.UserID == id); 
        User user = _context.Users.Single(x => x.UserID == id);
        _context.Remove(user);
        _context.SaveChanges();
    }
    
    public void SaveUser(User u)
    {
        _context.SaveChanges();
    }

    
}