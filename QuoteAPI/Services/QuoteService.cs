using QuoteAPI.Models;

namespace QuoteAPI.Services;

public class QuoteService
{
    private static readonly List<Quote> Quotes = new List<Quote>()
    {
        new Quote {Statement = "Would I rather be feared or loved? Easy. Both. I want people to be afraid of how much they love me."},
        new Quote {Statement = "I am a very good person."},
        new Quote {Statement = "Sometimes I'll start a sentence and I don’t even know where it’s going. I just hope I find it along the way."},
        new Quote {Statement = "I’m an early bird and a night owl. So I’m wise and I have worms."},
        new Quote {Statement = "I have cause. It is because I hate him."},
        new Quote {Statement = "I am a human being. I am not a number. I am not a robot."},
        new Quote {Statement = "I don’t think I’m the best person to ask, but I’m the only person here."},
        new Quote {Statement = "I am trying to remember what I did today. I am just so exhausted from being so good at my job."},
        new Quote {Statement = "I am the best boss. I mean, I’m not saying that, but it’s true"},
        new Quote {Statement = "I don’t care what they say about me. I just want to be great."}

    };
    public IEnumerable<Quote> GetQuotes()
    { 
        return Quotes; 
    }

}
