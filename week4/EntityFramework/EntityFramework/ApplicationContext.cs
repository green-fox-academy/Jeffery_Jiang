using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Todo> Todos { set; get; }
        public ApplicationContext( DbContextOptions options) : base(options)
        {

        }
    }
}
