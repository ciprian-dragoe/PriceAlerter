using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PriceAlerter.Models;
using PriceAlerterBusiness;

namespace PriceAlerter.Controllers;

public class LinksController : Controller
{
    private readonly ILogger<LinksController> _logger;
    private readonly IProductService _productService;

    public LinksController(ILogger<LinksController> logger, IProductService productService)
    {
        _logger = logger;
        _productService = productService;
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
        var product = _productService.ExtractProductFromDomain(domain);
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