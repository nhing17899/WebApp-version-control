using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp_version_control.Models;
using Microsoft.Extensions.Logging;


namespace WebApp_version_control.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public JsonResult Index()
    {
        var name = "Nhi Nguyen";
        return Json(new { Name = name });
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
