using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AngularNet.Models;

namespace AngularNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            var db = new VentaRealContext();
            var prueba = db.Clientes.ToList();
            foreach (var item in prueba)
            {
                Console.WriteLine($"Id: " + item.Id + ", Name: " + item.Nombre);
            }
            // List<WeatherForecast> lst = new List<WeatherForecast>();
            // lst.Add(new WeatherForecast() { Id = 5, Name = "Hector" });
            // lst.Add(new WeatherForecast() { Id = 6, Name = "Francisco" });
            return prueba;
        }
    }
}
