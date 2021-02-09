using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Keepr.Web.Models;
using Keepr.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Keepr.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly KeepsService _ks;


        [HttpGet]
        public Keep Get()
        {
            return _ks.GetKeep(46);
        }

        public WeatherForecastController(KeepsService ks)
        {
            _ks = ks;
        }
    }
}
