using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ninjaficator2020.BLL.Interface;

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
        private readonly INameGenerator _nameGenerator;

        public NinjifyController(ILogger<NinjifyController> logger, INameGenerator nameGenerator)
        {
            _logger = logger;
            _nameGenerator = nameGenerator;
        }

        /// <summary>
        /// ↑↑↓↓←→←→ba
        /// </summary>
        /// <param name="techName"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult Get([FromQuery(Name = "x")] string techName)
        {
            return new JsonResult(_nameGenerator.GenerateNinjaName(techName));
        }
    }
}
