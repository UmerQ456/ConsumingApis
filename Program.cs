using ConsumingApis.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Register CountryService and HttpClient using the factory
services.AddHttpClient<ICountryService, CountryService>();

// Build provider
var provider = services.BuildServiceProvider();

// Resolve the service and run the request
var service = provider.GetRequiredService<ICountryService>();
await service.GetCountryAsync("Pakistan");
