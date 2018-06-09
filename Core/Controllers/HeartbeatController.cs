using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [Route("core/heartbeat")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public object Heartbeat()
        {
            return new
            {
                Timestamp = Util.Date.Timestamp
            };
        }

        [HttpGet("Info")]
        public object ServiceInfo()
        {
            return new
            {
                Timestamp = Util.Date.Timestamp,
                Name = System.AppDomain.CurrentDomain.FriendlyName,
                IP = Util.Network.LocalIPAddress
            };
        }

        [HttpGet("Load")]
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