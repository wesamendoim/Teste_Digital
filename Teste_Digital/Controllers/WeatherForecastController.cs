using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Digital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            WeatherForecast proprietiesCards = new WeatherForecast();
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new WeatherForecast
            {
                CustomID = rng.Next(1, 300),
                CardNumber = proprietiesCards.CardNumber,
                CVV = proprietiesCards.CVV
            })
            .ToArray();
        }

        [HttpPost]
        public IEnumerable<WeatherForecast> Post()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new WeatherForecast
            {
                Date = DateTime.Now,
                TokenCard = rng.Next(1, 3),
                CardId = rng.Next(1, 300),

            }).ToArray();
            
        }

    }
}
