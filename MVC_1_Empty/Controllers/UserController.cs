using Microsoft.AspNetCore.Mvc;

namespace MVC_1_Empty.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult SignUp()
    {
        return View();
    }
}