using System.ComponentModel.DataAnnotations;

namespace ASP_NetProject.Models;

public class User
{
    public string UserID { get; set; }
    
    [Required(ErrorMessage = "Please enter your name")]
    public String Username { get; set; }
    
    [Required(ErrorMessage = "Please enter your password")]
    public String Password { get; set; }
    
}