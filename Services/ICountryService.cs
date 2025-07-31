namespace ConsumingApis.Services
{
    public interface ICountryService
    {
        Task GetCountryAsync(string name);
    }
}
