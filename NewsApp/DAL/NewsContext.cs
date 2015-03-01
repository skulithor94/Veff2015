using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace NewsApp.DAL
{
    public class NewsContext :DbContext
    {
        public NewsContext()
            :base("NewsContext")
        {

        }

        public DbSet<NewsItem> News { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}