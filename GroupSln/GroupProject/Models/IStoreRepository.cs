namespace ASP_NetProject.Models;

public interface IStoreRepository
{
    //TODO Her manglar okkurt at gera! Síða 181 PDF page
    IQueryable<User> Users { get; }
    
    void SaveUser(User u);
    void CreateUser(User u);
    void DeleteUser(long id);

    User SelectUser(long id);


}