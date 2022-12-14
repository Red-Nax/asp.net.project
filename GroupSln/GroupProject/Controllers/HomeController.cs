using System.Runtime.Intrinsics.Arm;
using ASP_NetProject.Models;
using GroupProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NetProject.Controllers;

public class HomeController : Controller
{
    private IToDoRepository repository;

    public HomeController(IToDoRepository repo)
    {
        repository = repo;
    }
    
    public IActionResult Index() => View(repository.Users);

    public IActionResult SignUp() => View();

    [HttpPost]
    public IActionResult SignUp(User user)
    {
        if (ModelState.IsValid) {
            repository.Create(user);
            return View("UserCreated", user);
        } else
        {
            return View();
        }
        //TODO CHECK FOR UNIQUE before CREATE USER
    }


    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Login(User user)
    {
        User u = repository.SelectByName(user.Username);

        if (user.Username == u.Username && user.Password == u.Password)
        {
            LoggedInUser.LoggedIn = true;
            LoggedInUser.User = user.Username;
        }

        return Redirect("/");
    }
    
    

    public IActionResult Users()
    {
        return View(repository.Users);
    }


    public IActionResult EditUser(long id)
    {
        User user = repository.Select(id);
        return View("EditUser", user);
    }
    
    [HttpPost]
    public IActionResult EditUser(User user)
    {
        repository.Save(user);
        
        return View("Users");
    }
    
    public IActionResult DetailsUser(long id)
    {
        User user = repository.Select(id);
        return View("DetailsUser", user);
    }
    
    public IActionResult DeleteUser(long id)
    {
        repository.DeleteUser(id);
        //return View();
        return Redirect("/home/users");
    }

    public IActionResult DeleteToDo(long id)
    {
        repository.DeleteToDo(id);
        //return View("Details");
        return Redirect("/home/ToDo");
    }

    public IActionResult ToDo()
    {
        UserViewModel userViewModel = 
            new UserViewModel { users = repository.Users, todos = repository.ToDos };
        return View(userViewModel);
    }
    
    [HttpPost]
    public IActionResult ToDo(UserViewModel userViewModel)
    {
        
        ToDo td = new ToDo
        {
            CreatorOfTask = userViewModel.CreatorOfTask,
            TaskTitle = userViewModel.TaskTitle,
            Description = userViewModel.Description,
            StartTime = DateTime.Now,
            EndTime = userViewModel.EndTime,
            UserId = userViewModel.UserId
        };
        
        repository.Create(td);
        
       UserViewModel uw = new UserViewModel { users = repository.Users, todos = repository.ToDos };
        return View(uw);
    }

    
    public IActionResult DetailsToDo(long id)
    {
        ToDo toDo = repository.selectToDo(id);
        
        User user = repository.Select(toDo.UserId);

        DetailsTodoViewModels dtw = new DetailsTodoViewModels { ToDo = toDo, Username = user.Username };
        
        return View("DetailsTodo",dtw);
    }

    public IActionResult EditTodo(long id)
    {
        ToDo toDo = repository.selectToDo(id);
        
        User user = repository.Select(toDo.UserId);

        DetailsTodoViewModels dtw = new DetailsTodoViewModels { ToDo = toDo, Username = user.Username, users = repository.Users};
        
        return View("EditTodo",dtw);
         
    }
    
    [HttpPost]
    public IActionResult EditTodo(DetailsTodoViewModels detailsTodoViewModels)
    {

        ToDo toDo = new ToDo
        {
            CreatorOfTask = @detailsTodoViewModels.ToDo.CreatorOfTask,
            TaskTitle = @detailsTodoViewModels.ToDo.TaskTitle,
            Description = detailsTodoViewModels.ToDo.Description,
            StartTime = detailsTodoViewModels.ToDo.StartTime,
            EndTime = detailsTodoViewModels.ToDo.EndTime,
            ToDoID = detailsTodoViewModels.ToDo.ToDoID,
            UserId = detailsTodoViewModels.ToDo.UserId
        };
        
        // ToDo toDo = repository.selectToDo(id);
        
        // User user = repository.Select(toDo.UserId);

        repository.Save(toDo);
        
        // DetailsTodoViewModels dtw = new DetailsTodoViewModels { ToDo = toDo, Username = user.Username, users = repository.Users};
        
        // return View("EditTodo",dtw);

        return Redirect("/home/ToDo");
    }
    
}