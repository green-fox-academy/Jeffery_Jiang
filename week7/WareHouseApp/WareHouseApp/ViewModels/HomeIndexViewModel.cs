using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseApp.Models;
using static WareHouseApp.Services.OrderServer;

namespace WareHouseApp.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Good> Goods { get; set; }
        public IEnumerable<BasketItemWithName> BasketItems { get; set; }
    }
}
