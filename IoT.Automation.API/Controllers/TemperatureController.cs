using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IoT.Automation.Data.Interfaces;

namespace IoT.Automation.API.Controllers
{
    public class TemperatureController : Controller
    {
        public IDbService DbService { get; set; }

        public TemperatureController(IDbService dbService)
        {
            DbService = dbService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult AddTemperature(double fehrenheight, double celcius, double Humidity)
        {
            DbService.AddTemperature(fehrenheight, celcius, Humidity, DateTime.Now);
            return Ok();
        }
    }
}