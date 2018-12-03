using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenFoxApp.Servers;
using GreenFoxApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreenFoxApp.Controllers
{
    public class FoxController : Controller
    {
        private readonly IFoxService service;

        public FoxController(IFoxService service)
        {
            this.service = service;
        }

        [HttpGet("/nutritionStore")]
        public IActionResult NutritionStore(string name)
        {

            var fox = service.FindFox(name);
            return View(fox);
        }

        [HttpPost("/nutritionStore/{name}")]
        public IActionResult FeedPet(string food,string name)
        {
            var fox = service.FindFox(name);
            var oldfood = fox.Foods;
            service.ChangeFood(name,food);

            var action = $"{DateTime.Now.ToString()} {name} changed food from {oldfood} to {food} ";
            service.RecordAction(action,name);
            return Redirect($"/?name={name}");
        }

        [HttpGet("/trickcenter")]
        public IActionResult TrickCenter(string name)
        {
            var fox = service.FindFox(name);
            return View(fox);
        }

        [HttpPost("/trickcenter/{name}")]
        public IActionResult AddTricks(string name,string trick)
        {
            
           service.ChangeTrick(name,trick);
            //fox = service.FindFox(name);
            var action = $"{DateTime.Now.ToString()} {name} Learned {trick}";
            service.RecordAction(action,name);
            return Redirect($"/?name={name}");
        }

        [HttpPost("/unlearntrick")]
        public IActionResult UnlearnTrick(string trick, string name)
        {
            service.UnlearnTrick(name,trick);
            var action = $"{DateTime.Now.ToString()} {name} unlearned {trick}";
            service.RecordAction(action,name);
            return Redirect($"/trickcenter/?name={name}");
        }

        [HttpGet("/actionrecord")]
        public IActionResult AcctionRecord(string name, string action)
        {
            //this method is to read action
            var fox = service.FindFox(name);
            //service.AddAction(name,action);
            return View(fox);
        }
    }
}