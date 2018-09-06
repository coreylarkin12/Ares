using System;
using Microsoft.AspNetCore.Mvc;
using Clockwork.API.Models;
using System.Linq;
using System.Collections.ObjectModel;

namespace Clockwork.API.Controllers
{
    //[Route("api/[controller]")]
    public class CurrentTimeController : Controller
    {
        // GET api/currenttime
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var utcTime = DateTime.UtcNow;
            var serverTime = DateTime.Now;
            var ip = this.HttpContext.Connection.RemoteIpAddress.ToString();

            var returnVal = new CurrentTimeQuery
            {
                UTCTime = utcTime,
                ClientIp = ip,
                Time = serverTime
            };

          
            using (var db = new ClockworkContext())
            {
                db.CurrentTimeQueries.Add(returnVal);
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                foreach (var CurrentTimeQuery in db.CurrentTimeQueries)
                {
                    Console.WriteLine(" - {0}", CurrentTimeQuery.UTCTime);
                }
            }

            return Json(returnVal, new Newtonsoft.Json.JsonSerializerSettings() { DateFormatString = "hh:mm tt" });
        }

        [HttpGet]
        [Route("api/[action]")]
        public IActionResult GetAll()
        {
            var context = new ClockworkContext();

            var selectAll = context.CurrentTimeQueries.OrderByDescending(x => x.CurrentTimeQueryId).ToList();

            ReadOnlyCollection<TimeZoneInfo> tz;
            tz = TimeZoneInfo.GetSystemTimeZones();

            return Json(selectAll, new Newtonsoft.Json.JsonSerializerSettings() { DateFormatString = "hh:mm tt" });

        }

        [HttpGet]
        [Route("api/[action]")]
        public IActionResult SelectTimeZone()
        {

            ReadOnlyCollection<TimeZoneInfo> tz;
            tz = TimeZoneInfo.GetSystemTimeZones();

            tz.OrderBy(x => x.DisplayName).ToList();

            return Json(tz, new Newtonsoft.Json.JsonSerializerSettings() { DateFormatString = "hh:mm tt" });

        }
    }
}
