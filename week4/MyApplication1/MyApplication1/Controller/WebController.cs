
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication1.Models;

namespace MyApplication1.Controller
{
    [Route("web")]
    public class WebController : Microsoft.AspNetCore.Mvc.Controller
    {
        private static long count=0;
        [HttpGet("greeting")]
        public IActionResult Greeting()
        {
            count++;
            var greeting = new Greeting()
            {
                Id = count,
                Content = "from the model"
            };

            return View(greeting);
        }
    }
}