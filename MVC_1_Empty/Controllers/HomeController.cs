using Microsoft.AspNetCore.Mvc;

namespace MVC_1_Empty.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View("Info");
    }

    public IActionResult Test()
    {
        return View();
    }
    
}