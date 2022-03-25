using Microsoft.AspNetCore.Mvc;

namespace E_commerce.CustomerSite.Controllers;

public class ClassifyController : Controller
{
    private readonly ILogger<ClassifyController> _logger;

    public ClassifyController(ILogger<ClassifyController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}