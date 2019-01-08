using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxCoinProject.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FoxCoinProject
{
    public class FoxBankContext : DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<TransAction> TransActions { get; set; }
        public FoxBankContext(DbContextOptions options) : base(options)
        {
        }
    }
}
