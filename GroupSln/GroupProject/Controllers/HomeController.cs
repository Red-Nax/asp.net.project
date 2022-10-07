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


    public IActionResult Register() => View();

}