using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PriacticeDependencyInjection.Services;

namespace PriacticeDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly UtilityService service;

        public HomeController(UtilityService service)
        {
            this.service = service;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("/useful")]
        public IActionResult Useful()
        {
            return View();
        }

        [HttpGet("/useful/colored")]
        public IActionResult ColoredBackground()
        {

            return View(this.service);
        }

        [HttpPost("/useful/email/{email}")]
        public IActionResult CheckEmail(string email)
        {
            service.ValidateEmail(email);
            return RedirectToAction(nameof(Email));
        }

        [HttpGet("/useful/email")]
        public IActionResult Email()
        {
            return View(service);
        }
        
    }
}