namespace Prerender.shared
{
    public interface IWeatherforecastService
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }
}