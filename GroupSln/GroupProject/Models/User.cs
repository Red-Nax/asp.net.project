using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models;

public class User
{
    //Primary key
    public long? UserId { get; set; }
    
    // Required input field
    [Required(ErrorMessage = "Please enter your name")]
    public string Username { get; set; }
    
    [Required(ErrorMessage = "Please enter your password")]
    public string Password { get; set; }
    
    
}