using Microsoft.AspNetCore.Mvc;
using QuoteAPI.Services;

namespace QuoteAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class QuotesController : Controller
{
    private readonly QuoteService _quoteService;
    public QuotesController(QuoteService quoteService)
    {
        _quoteService = quoteService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var quotes = _quoteService.GetQuotes();
        return Ok(quotes);
    }
}
