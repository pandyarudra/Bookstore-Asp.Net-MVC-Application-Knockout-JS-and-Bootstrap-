using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProfileWebsite;
using ProfileWebsite.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProfileWebsite.DAL
{
    public class BookContext : DbContext
    {
        public BookContext(): base("BookContext")
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}