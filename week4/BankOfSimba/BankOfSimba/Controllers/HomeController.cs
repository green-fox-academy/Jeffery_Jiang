using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        private static List<BankAccount> accountList= new List<BankAccount>();
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("show")]
        public IActionResult Show()
        {
           // BankAccount bankAccount=new BankAccount("Simba", 2000,Currencies.Zebra,"Lion");
            return View(accountList);
        }

        [HttpGet("useless")]
        public IActionResult UselessText()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult AddAccount(BankAccount account)
        {
            accountList.Add(account);
            return RedirectToAction(nameof(Show));
        }

        [HttpPost("raisebalance/{name}")]
        public IActionResult RaiseBalance(string name)
        {
            foreach (var account in accountList)
            {
                
                if (account.Name==name)

                {
                    if (account.Name == "Simba")
                    {
                        account.Balance += 100;

                    }
                    else
                    {
                        account.Balance += 10;
                    }
                }
            }
            return RedirectToAction(nameof(Show));
        }
    }
}