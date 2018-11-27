using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyApplication1.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        [Route("/")]
        public IActionResult Index()
        {

            return View();
        }
    }
}