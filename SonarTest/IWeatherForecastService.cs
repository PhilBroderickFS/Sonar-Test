using System.Collections;
using System.Collections.Generic;

namespace SonarTest
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecast(int numOfForecasts);
    }
}