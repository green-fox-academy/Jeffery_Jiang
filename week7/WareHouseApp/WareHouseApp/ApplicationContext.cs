using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseApp.Models;

namespace WareHouseApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItem { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<OrderHistory> OrderHistory { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public ApplicationContext( DbContextOptions options) : base(options)
        {

        }
    }
}
