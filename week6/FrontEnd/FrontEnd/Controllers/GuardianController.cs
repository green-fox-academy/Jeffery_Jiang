using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class RespondMessage
    {
        public string Recieved { get; set; }
        public string Teanslated { get; set; }
        public string Error { get; set; }
    }

    public class ArrowInformation
    {
        public double Distance { get; set; }
        public double Time { get; set; }

        public double? Speed { get; set; }
    }
    public class GuardianController : ControllerBase
    {
        [HttpGet("groot")]
        public ActionResult<RespondMessage> GrootTranslation(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return new RespondMessage { Error = "I am Groot!" };
            }

            return new RespondMessage
            {
                Recieved = message,
                Teanslated = "I am Groot!"
            };
        }

        [HttpGet("yondu")]
        public ActionResult<ArrowInformation> YonduArrow(double distance, double time)
        {
            try
            {
                var speed = distance / time;
                
                return new  ArrowInformation()
                {
                    Speed = speed,
                    Distance = distance,
                    Time = time
                };

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}