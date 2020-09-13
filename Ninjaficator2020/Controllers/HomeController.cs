using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ninjaficator2020.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new JsonResult("hello world!");
        }
    }
}
