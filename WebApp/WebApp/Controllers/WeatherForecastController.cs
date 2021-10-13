using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<WeatherForecast> _weatherForecasts = new List<WeatherForecast>();

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecasts;
        }

        [HttpPost]
        public void Post(WeatherForecast weatherForecasts)
        {
            _weatherForecasts.Add(weatherForecasts);
        }

        [HttpPut("{temperature}")]
        public void Put(int temperature)
        {
            List<WeatherForecast> itemsToUpdate = _weatherForecasts.Where(r => r.TemperatureC == temperature).ToList();

            foreach (var item in itemsToUpdate)
            {
                item.TemperatureC = 0;
            }
        }

        [HttpDelete("{temperature}")]
        public void Delete(int temperature)
        {
            List<WeatherForecast> itemsToRemove = _weatherForecasts.Where(r => r.TemperatureC == temperature).ToList();

            foreach (var item in itemsToRemove)
            {
                _weatherForecasts.Remove(item);
            }
        }
    }
}
