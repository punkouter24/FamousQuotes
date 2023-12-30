using System.Net.Http.Json;

namespace FamousQuotes;

public class QuoteService
{
    private readonly HttpClient _httpClient;

    public QuoteService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Quote>> GetRandomQuotesAsync(int count = 10)
    {
        try
        {
            var response = await _httpClient.GetFromJsonAsync<List<Quote>>($"https://api.quotable.io/quotes/random?limit={count}");
            return response ?? new List<Quote>();
        }
        catch (Exception ex)
        {
            // Handle or log the exception
            return new List<Quote>();
        }
    }



}
