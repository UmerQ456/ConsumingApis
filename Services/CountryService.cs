//using System.Net.Http;
using System.Text.Json;
using ConsumingApis.Models;

namespace ConsumingApis.Services
{
    public class CountryService : ICountryService
    {
        private readonly HttpClient _client; //declaring a private readonly field of type Httpclient to be used later

        public CountryService(HttpClient client)
        {
            _client = client;
        }

        public async Task GetCountryAsync(string name)
        {
            var url = $"https://restcountries.com/v3.1/name/{name}";
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var countries = JsonSerializer.Deserialize<List<Country>>(json);

            var country = countries?.FirstOrDefault();
            if (country is not null)
            {
                Console.WriteLine($"Name: {country.Name.Common}");
                Console.WriteLine($"Capital: {string.Join(", ", country.Capital)}");
                Console.WriteLine($"Region: {country.Region}");
            }
            else
            {
                Console.WriteLine("No country data found.");
            }
        }
    }
}
