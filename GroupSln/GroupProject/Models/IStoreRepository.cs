namespace GroupProject.Models;

public interface IStoreRepository
{
    //TODO Her manglar okkurt at gera! Síða 181 PDF page
    IQueryable<User> Users { get; }
    IQueryable<ToDo> ToDos { get; }

    // Instance overload
    void Create(User u);
    void Create(Task t);
    void Save(User u);
    void Save(Task t);
    
    // General instances
    void Delete(long id);
    User Select(long id);


}