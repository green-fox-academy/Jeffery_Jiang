using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseApp.Models
{
    public class OrderItem
    {
        public long OrderItemId { get; set; }
        public Good Good { get; set; }
        public int Quantity { get; set; }
        public OrderHistory Order { get; set; }
    }
}
