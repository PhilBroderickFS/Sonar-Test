using System;
using System.Collections.Generic;
using System.Linq;

namespace SonarTest
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        
        public IEnumerable<WeatherForecast> GetWeatherForecast(int numOfForecasts)
        {
            var rng = new Random();
            return Enumerable.Range(1, numOfForecasts).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToArray();
        }
    }
}