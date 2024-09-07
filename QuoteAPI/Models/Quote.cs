using System.Text.Json.Serialization;

namespace QuoteAPI.Models;

public class Quote
{
    [JsonPropertyName("statement")]
    public string? Statement { get; set; }
}
