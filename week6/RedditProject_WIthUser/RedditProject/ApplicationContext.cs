using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using RedditProject.Models;

namespace RedditProject
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts { set; get; }
        public DbSet<User> Users { set; get; }
        

    }
}
