using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [Route("core")]
    public class ValuesController : Controller
    {
        [HttpGet("heartbeat")]
        public IActionResult Heartbeat()
        {
            return Ok(new
            {
                Timestamp = Util.Date.Timestamp
            });
        }

        [HttpGet("info")]
        public IActionResult ServiceInfo()
        {
            return Ok(new
            {
                Timestamp = Util.Date.Timestamp,
                Name = System.AppDomain.CurrentDomain.FriendlyName,
                IP = Util.Network.LocalIPAddress
            });
        }

        [HttpGet("load")]
        public object Load()
        {
            return new
            {
                LastMin = 25,
                Last10Min = 500
            };
        }
    }
}