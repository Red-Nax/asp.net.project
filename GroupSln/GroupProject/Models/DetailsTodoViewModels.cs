namespace GroupProject.Models;

public class DetailsTodoViewModels
{
    public string Username { get; set; }
    public ToDo ToDo { get; set; }
    
    public IQueryable<User>? users { get; set; }

}