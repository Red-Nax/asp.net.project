using System.Runtime.Intrinsics.Arm;
using ASP_NetProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NetProject.Controllers;

public class HomeController : Controller
{
    private IStoreRepository repository;

    public HomeController(IStoreRepository repo)
    {
        repository = repo;
    }


    public IActionResult Index() => View(repository.Users);

    public IActionResult Login() => View();

    [HttpPost]
    public IActionResult Login(User user)
    {
        if (ModelState.IsValid) {
            repository.CreateUser(user);
            return View("UserCreated", user);
        } else
        {
            return View();
        }
        //TODO CHECK FOR UNIQUE before CREATE USER
    }


    public IActionResult Details()
    {
        return View(repository.Users);
    }



    public IActionResult EditUser(long id)
    {
        return View();
    }
    
    public IActionResult DetailsUser(long id)
    {
        return View();
        
    }
    
    public IActionResult DeleteUser(long id)
    {
        repository.DeleteUser(id);
        return View();
    }

}