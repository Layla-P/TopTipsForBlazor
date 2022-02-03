using Prerender.shared;
using System.Net.Http.Json;

namespace Prerender.client
{
    public class ClientWeatherForecastService :IWeatherforecastService
    {
        private readonly HttpClient _httpClient;

        public ClientWeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("api/WeatherForecast");
        }
    }
}
