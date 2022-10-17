namespace GroupProject.Models;

public interface IToDoRepository
{
    //TODO Her manglar okkurt at gera! Síða 181 PDF page
    IQueryable<User> Users { get; }
    IQueryable<ToDo> ToDos { get; }

    // Instance overload
    void Create(User u);
    void Create(ToDo t);
    void Save(User u);
    
    void Save(ToDo t);
    
    // General instances
    void DeleteUser(long id);
    void DeleteToDo(long id);
    
    User Select(long id);

    User SelectByName(string username);

    ToDo selectToDo(long id);


}