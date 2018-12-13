using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using FrontEnd.Models;
namespace FrontEnd
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Log> Logs { set; get; }
        public ApplicationContext( DbContextOptions options) : base(options)
        {
        }
    }
}
