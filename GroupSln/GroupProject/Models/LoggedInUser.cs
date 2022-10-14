namespace GroupProject.Models;

public class LoggedInUser
{
    public static bool LoggedIn { get; set; } = false; 
    
    public static string User { get; set; }
}