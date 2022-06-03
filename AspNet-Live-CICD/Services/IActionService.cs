using System.Collections.Generic;

namespace AspNet_Live_CICD.Services
{
    public interface IActionService
    {
        IEnumerable<WeatherForecast> Get();
    }
}