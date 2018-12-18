using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WareHouseApp.Models;

namespace WareHouseApp.Services
{
    public class OrderServer : IOrderServer
    {
        public class BasketItemWithName
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
        }
        private readonly ApplicationContext applicationContext;

        public OrderServer(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public IEnumerable<Good> FindAllGoods()
        {
            return applicationContext.Goods;
        }

        public IEnumerable<BasketItemWithName> FindAllBasketItems()
        {
            var result = from g in applicationContext.Goods
                         join b in applicationContext.BasketItem
                             on g.GoodId equals b.Good.GoodId
                         select new BasketItemWithName()
                         {
                             Name = g.Name,
                             Quantity = b.Quantity
                         };
            return result;
        }

        public void AddItemToBasket(long goodId, int quantity)
        {
            var basket = applicationContext.Baskets.Find((long)1);
            if (applicationContext.BasketItem.Find(goodId) is null)
            {
                var good = applicationContext.Goods.Find(goodId);
                var basketItem = new BasketItem()
                {
                    Basket = basket,
                    Good = good,
                    Quantity = quantity
                };
                applicationContext.BasketItem.Add(basketItem);
            }
            else
            {
                var existedBasketItem = applicationContext.BasketItem.Find(goodId);
                existedBasketItem.Quantity += quantity;

            }
            applicationContext.SaveChanges();
        }

        public void MakeNewOrder()
        {

            var custmorName = "Jeffery";
            applicationContext.Database.ExecuteSqlCommand("exec SubmitNewOrder @custmorName, @OrderId output",new SqlParameter("@custmorName",custmorName),
                new SqlParameter("@OrderId", SqlDbType.Int){ Direction = ParameterDirection.Output});
           // applicationContext.SaveChanges();

        }

        public void ClearBasket()
        {
            var basketList = applicationContext.BasketItem;
            foreach (var item in basketList)
            {
                basketList.Remove(item);
            }

            applicationContext.SaveChanges();
        }
    }
}
