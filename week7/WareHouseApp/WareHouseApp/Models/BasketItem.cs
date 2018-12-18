using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseApp.Models
{
    public class BasketItem
    {
        public long BasketItemId { get; set; }
        public Good Good { get; set; }
        public int  Quantity { get; set; }
        public Basket Basket { get; set; }
    }
}
