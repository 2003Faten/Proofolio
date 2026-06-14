using System.Diagnostics;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Proofolio.Models;

namespace Proofolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult CV()
    {
        return View();
    }

    public IActionResult Planning()
    {
        return View();
    }

    public IActionResult Requirements()
    {
        return View();
    }

    public IActionResult Analysis()
    {
        return View();
    }

    public IActionResult UIUX()
    {
        return View();
    }

    public IActionResult Development()
    {
        return View();
    }

    public IActionResult Testing()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
