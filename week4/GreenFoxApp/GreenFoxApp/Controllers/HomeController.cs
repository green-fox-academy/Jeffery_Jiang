using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenFoxApp.Models;
using GreenFoxApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreenFoxApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoxService foxService;
      //  private static string foxname="";
        public HomeController(IFoxService foxService)
        {
            this.foxService = foxService;
        }
        [HttpGet("/")]
        public IActionResult Index(string name)
        {
            
            if (name == null)
            {
                return View("IndexWithName");
            }
            else
            {
                var fox = foxService.FindFox(name);
                return View("Index", fox);
            }
        }

        [HttpGet("/creating")]
        public IActionResult Creating()
        {
            return View();
        }

        [HttpPost("/creating")]
        public IActionResult CreatPet(string tricks, string name, string foods)
        {
            string[] tricklist= tricks.Split('\n');
            for (int i = 0; i < tricklist.Length; i++)
            {
                tricklist[i] = tricklist[i].Replace("\r", "");
            }
            Fox newFox= new Fox()
            {
                Name = name,
                Foods = foods,
                Tricks = new List<string>()
                    
            };
            foreach (var s in tricklist)
            {
                newFox.Tricks.Add(s);
            }

            foxService.Add(newFox);
            return RedirectToAction(nameof(Login));
        }
        
        [HttpGet("login")]
        public IActionResult Login()
        {
            var foxs = foxService.FindAll();
            return View("Login",foxs);
        }
        [HttpPost("login")]
        public IActionResult EnterName(string name)
        {

            //foxname = name;
            return Redirect($"/?name={name}");
        }

        
    }
}