using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using WareHouseApp.Models;
using WareHouseApp.Services;
using WareHouseApp.ViewModels;

namespace WareHouseApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderServer orderServer;

        public HomeController(IOrderServer orderServer)
        {
            this.orderServer = orderServer;
        }

        public IActionResult Index()
        {
            var goodList = orderServer.FindAllGoods().ToList();
            var baketItemList = orderServer.FindAllBasketItems().ToList();

            var viewModel = new HomeIndexViewModel
            {
                BasketItems = baketItemList,
                Goods = goodList
            };

            return View(viewModel);
        }

        [HttpPost("addItemToBasket")]
        public IActionResult AddItemToBasket(long goodId,int quantity)
        {
            orderServer.AddItemToBasket(goodId,quantity);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost("makeNewOrder")]
        public IActionResult MakeNewOrder()
        {
            orderServer.MakeNewOrder();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost("clearBasket")]
        public IActionResult ClearBasket()
        {
            orderServer.ClearBasket();
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
