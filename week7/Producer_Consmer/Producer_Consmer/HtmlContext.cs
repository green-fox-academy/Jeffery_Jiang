using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Producer_Consumer
{
    class HtmlContext : DbContext
    {
        public DbSet<HtmlFeature> HtmlFeatureList { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=HtmlInformation;Integrated Security=SSPI");
        }
    }
}
