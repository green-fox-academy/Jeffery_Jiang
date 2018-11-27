using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication1.Models;

namespace MyApplication1.Controller
{
    [Route("api")]
    public class RestController : Microsoft.AspNetCore.Mvc.Controller
    {
        private static long count=1;

        [HttpGet("greeting")]
        public Greeting Greet(string name)
        {
            Greeting greeting=new Greeting();
            greeting.Content = name;
            greeting.Id = count;
            count++;
            return greeting;
        }

    }
}