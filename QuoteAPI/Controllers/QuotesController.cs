using Microsoft.AspNetCore.Mvc;

namespace QuoteAPI.Controllers;
public class QuotesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
