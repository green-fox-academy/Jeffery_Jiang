using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseApp.Models;
using static WareHouseApp.Services.OrderServer;

namespace WareHouseApp.Services
{
    public interface IOrderServer
    {
        IEnumerable<Good> FindAllGoods();
        IEnumerable<BasketItemWithName> FindAllBasketItems();
        void AddItemToBasket(long goodId, int quantity);
        void MakeNewOrder();
        void ClearBasket();
    }
}
