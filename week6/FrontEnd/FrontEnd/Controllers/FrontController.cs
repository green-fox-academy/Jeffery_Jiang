using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontEnd.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontEnd.Controllers
{
    //[Route("api/[controller]")]
    public class FrontController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public FrontController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public class Doubling
        {
            public int Received { get; set; }
            public int Result { get; set; }
            public string Error { get; set; }
        }

        public class Greeter
        {
            public string Welcome_message { get; set; }

            public string Error { get; set; }
        }

        public class Appender
        {
            // public string Original { get; set; }
            public string Appended { get; set; }
        }

        public class NumOperator
        {
            public int Until { get; set; }

        }

        public class NumOperatorResult
        {
            public int Result { get; set; }
        }
        // GET: api/<controller>
        public class EntireLogs
        {
            public List<Log> Entries { set; get; }
            public int Entry_Count { get; set; }
        }
        [HttpGet("doubling")]
        public ActionResult<Doubling> GetDoubling(int? input)
        {
            var log = new Log
            {
                Data = $"input={input}",
                EndPoint = "/doubling"
            };
            applicationContext.Logs.Add(log);
            applicationContext.SaveChanges();
            if (input is null)
            {
                return new Doubling()
                {
                    Error = "Please proviede an input",

                };
            }
            else
            {

                return new Doubling()
                {
                    Result = (int)input * 2,
                    Received = (int)input
                };
            }

            ;
        }

        // GET api/<controller>/5
        [HttpGet("greeter")]
        public ActionResult<Greeter> GetGreeter(string name, string title)
        {
            var log = new Log
            {
                EndPoint = "/greeter",
                Data = $"name={name}&title={title}"
            };
            applicationContext.Logs.Add(log);
            applicationContext.SaveChanges();
            if (name is null || title is null)
            {
                return new Greeter { Error = "Please Provide a name" };
            }
            else
            {
                return new Greeter { Welcome_message = $"Oh, hi there {name}, my dear {title}!" };
            }
        }

        [HttpGet("/appenda/{appendable}")]
        public ActionResult<Appender> AppendeResult(string appendable)
        {
            var log = new Log {Data = $"appendable={appendable}"};
            applicationContext.Logs.Add(log);
            applicationContext.SaveChanges();
            return new Appender { Appended = appendable + "a" };
        }
        //// POST api/<controller>
        //[HttpPost("dountil/{doaction}")]
        ////public ActionResult<NumOperatorResult> Post([FromBody] NumOperator op, [FromRoute] string doaction)
        ////{
        ////    var result = 0;
        ////    var temp = op.Until;

        ////}
        //// PUT api/<controller>/5
        [HttpPost("arrays")]
        public ActionResult<object> ArrayHandlerActionResult([FromBody]ArrayHandler handler)
        {

            int result = 0;
            int temp = 0;
            switch (handler.What)
            {
                case "sum":
                    foreach (var number in handler.Numbers)
                    {
                        result += number;
                    }

                    return new {Result = result};
                case "multiply":
                    result = 1;
                    foreach (var number in handler.Numbers)
                    {
                        result *= number;
                    }

                    return new {Result = result};
                case "double":
                    List<int> resultForDouble=new List<int>();
                    foreach (var number in handler.Numbers)
                    {
                        resultForDouble.Add(number*2);
                    }
                    return new {Result = resultForDouble};
                case null:
                    return new  {Error = "Please provide what to do with the numbers!"};
                default:
                    throw new InvalidOperationException("unknown operation");

            }
        }

        [HttpGet("log")]
        public ActionResult<EntireLogs> LogEntires()
        {
            var entireLogs=new EntireLogs()
            {
                Entry_Count = 0,
                Entries = new List<Log>()

            };
            foreach (var log in applicationContext.Logs)
            {
                entireLogs.Entries.Add(log);
                entireLogs.Entry_Count++;
            }

            return entireLogs;
        }

        
    }
}
