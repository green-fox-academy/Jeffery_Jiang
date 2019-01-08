using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxCoinProject.Models;
using FoxCoinProject.Services;

namespace FoxCoinProject.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBankAccountServer bankAccountServer;

        public HomeController(IBankAccountServer bankAccountServer)
        {
            this.bankAccountServer = bankAccountServer;
            
        }

        public async Task<IActionResult> Index()
        {
            var accountList = await bankAccountServer.FindAllAccounts();
            return View(accountList);
        }
        [HttpGet("foxcoinpage")]
        public async Task<IActionResult> FoxCoinPage(long userId)
        {
            var accountList = await bankAccountServer.FindAllAccounts();
           // var currentUser= await bankAccountServer.FindById(userId);
            ViewBag.CurrentUserId = userId;
            //ViewBag.CoinRecord = coinRecordList.FirstOrDefault(c=>c.UserId==userId);
            return View(accountList);
        }

        [HttpPost("generateCoin")]
        public async Task<IActionResult> GenerateCoin(long userId)
        {
           
            await bankAccountServer.GenerateCoin(userId);
            //ViewBag.CurrentUser = await bankAccountServer.FindById(userId);
            return Redirect($"foxcoinpage?userId={userId}");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
