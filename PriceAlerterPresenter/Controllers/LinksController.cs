using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PriceAlerter.Models;

namespace PriceAlerter.Controllers;

public class LinksController : Controller
{
    private readonly ILogger<LinksController> _logger;

    public LinksController(ILogger<LinksController> logger)
    {
        _logger = logger;
    }

    public IActionResult List()
    {
        return View();
    }

    public IActionResult Add()
    {
        return View();
    }

    public IActionResult ValidateDomain(string domain)
    {
        
        return RedirectToAction("SetLimitPrice");
    }

    public IActionResult SetLimitPrice()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}