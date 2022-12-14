
namespace GroupProject.Models;

public class EFToDoRepository : IToDoRepository
{
    private ToDoDbContext _context;

    public EFToDoRepository(ToDoDbContext ctx)
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
        _context.Update(t);
        _context.SaveChanges();
    }

    public void DeleteUser(long id)
    {
        // IEnumerable<User> users = _context.Users.Where(x => x.UserID == id); 
        User user = _context.Users.Single(x => x.UserId == id);
        _context.Remove(user);
        _context.SaveChanges();
    }
    
    public void DeleteToDo(long id)
    {
        // IEnumerable<User> users = _context.Users.Where(x => x.UserID == id); 
        ToDo todo = _context.ToDos.Single(x => x.ToDoID == id);
        _context.Remove(todo);
        _context.SaveChanges();
    }
    
    public void Save(User u)
    {
        _context.Update(u);
        _context.SaveChanges();
    }

    public User Select(long id)
    {
        User user = _context.Users.Single(x => x.UserId == id);
        return user;
    }

    public User SelectByName(string username)
    {
        User user = _context.Users.Single(x => x.Username == username);
        return user;
    }


    public ToDo selectToDo(long id)
    {
        return _context.ToDos.Single(x => x.ToDoID == id);
        
    }
    
    
}