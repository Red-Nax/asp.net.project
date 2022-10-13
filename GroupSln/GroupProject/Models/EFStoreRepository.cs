
namespace GroupProject.Models;

public class EFStoreRepository : IStoreRepository
{
    private StoreDbContext _context;

    public EFStoreRepository(StoreDbContext ctx)
    {
        _context = ctx;
    }
    public IQueryable<User> Users => _context.Users;
    public IQueryable<ToDo> ToDos => _context.ToDos;

    public void Create(User u)
    {
        _context.Add(u);
        _context.SaveChanges();
    }

    public void Create(ToDo t)
    {
        _context.Add(t);
        _context.SaveChanges();
    }

    public void Save(ToDo t)
    {
        throw new NotImplementedException();
    }

    public void Delete(long id)
    {
        // IEnumerable<User> users = _context.Users.Where(x => x.UserID == id); 
        User user = _context.Users.Single(x => x.UserId == id);
        _context.Remove(user);
        _context.SaveChanges();
    }
    
    public void Save(User u)
    {
        _context.SaveChanges();
    }

    public User Select(long id)
    {
        User user = _context.Users.Single(x => x.UserId == id);
        return user;
    }

    
}