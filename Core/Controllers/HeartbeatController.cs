using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [Route("core/heartbeat")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public string Heartbeat()
        {
            return "Het werkt!";
        }
    }
}
