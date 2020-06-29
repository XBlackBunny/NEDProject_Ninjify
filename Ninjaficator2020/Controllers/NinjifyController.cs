using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ninjaficator2020.BLL;
using Ninjaficator2020.Model;

namespace Ninjaficator2020.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NinjifyController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<NinjifyController> _logger;

        public NinjifyController(ILogger<NinjifyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get([FromQuery(Name = "techname")] string techName)
        {
            return NameGenerator.GenerateNinjaName(techName);
        }
    }
}
