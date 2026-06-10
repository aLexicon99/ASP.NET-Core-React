using Microsoft.AspNetCore.Mvc;
using ReactApp_ASP.NET_Core.Server.Models;

namespace ReactApp_ASP.NET_Core.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //[HttpGet]
        //public IActionResult Get(int id)
        //{
        //    var products = new[]
        //    {
        //        new { Id = 1, Name = "Laptop", Price = 80000 },
        //        new { Id = 2, Name = "Mobile", Price = 30000 }
        //    };

        //    return Ok(products);
        //}
    }
}
