using Microsoft.AspNetCore.Mvc;

namespace PizzariaAspNet.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
