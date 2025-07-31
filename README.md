# ConsumingApis (.NET 8)

This is a simple .NET 8 console project that demonstrates how to consume a public REST API using clean architecture and best practices. The code is inspired by FastAPI-style structure for improved readability and maintainability.

## What It Does

- Sends an HTTP GET request to [restcountries.com](https://restcountries.com/)
- Fetches data about a country (name, capital, region, etc.)
- Deserializes the JSON response into C# objects
- Displays the data in the console

## Technologies Used

- .NET 8
- C#
- `HttpClientFactory`
- `System.Text.Json` for JSON serialization
- Dependency Injection (`Microsoft.Extensions.DependencyInjection`)

## Project Structure
`ConsumingApis/
│
├── Program.cs // Entry point, sets up DI and runs service
├── Services/
│ ├── ICountryService.cs // Interface for country service
│ └── CountryService.cs // Implementation that calls the API
└── Models/
└── Country.cs // C# model for JSON mapping`


## How to Run

1. **Clone the repo**  
   ```bash
   git clone https://github.com/UmerQ456/ConsumingApis.git
   cd ConsumingApis

## Sample Output
  Name: Canada
  Capital: Ottawa
  Region: Americas


