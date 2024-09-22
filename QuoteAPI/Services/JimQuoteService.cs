using QuoteAPI.Models;

namespace QuoteAPI.Services;

public class JimQuoteService
{
    private static readonly List<Quote> Quotes = new List<Quote>()
    {
        new Quote { Statement = "Sometimes you gotta work a little, so you can ball a lot." },
        new Quote { Statement = "It’s never too early for ice cream." },
        new Quote
        {
            Statement =
                "I am about to do something very bold in this job that I've never done before: try to be honest."
        },
    };

    public IEnumerable<Quote> GetQuotes()
    {
        return Quotes;
    }
}