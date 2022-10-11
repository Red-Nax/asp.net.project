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
        repository.CreateUser(user);
        return View();
    }


    public async Task<IActionResult> Details()
    {
        return View(repository.Users.ToList());
    }

    // [HttpGet]
    // public ViewResult RsvpForm() {
    //     return View();
    // }
    // [HttpPost]
    // public ViewResult RsvpForm(GuestResponse guestResponse) {
    //     // TODO: store response from guest
    //     return View();
    // }
}