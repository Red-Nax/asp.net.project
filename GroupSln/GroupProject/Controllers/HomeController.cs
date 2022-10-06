using System.Runtime.Intrinsics.Arm;
using ASP_NetProject.Models;

namespace ASP_NetProject.Controllers;

using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private User user = new User { UserID = "1", Name = "dp", Password = "1234" };
    
    public ViewResult Index() => View(new User { UserID = "1", Name = "dp", Password = "1234" });
}