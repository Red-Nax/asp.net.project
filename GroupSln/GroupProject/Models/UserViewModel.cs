using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models;

public class UserViewModel
{
    public IQueryable<User>? users { get; set; }
    public IQueryable<ToDo>? todos { get; set; }
    
    
    
    // Primary key in the table
    // public long? ToDoID { get; set; }
    
    // Foreign key in the table
    public long UserId { get; set; }
    
    // Required input from user
    [Required(ErrorMessage = "Please enter a title!")]
    public string TaskTitle { get; set; }
    
    // Setting the creator of the task
    public string CreatorOfTask  { get; set; }
    
    // Optional input from user
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? Description { get; set; }


}