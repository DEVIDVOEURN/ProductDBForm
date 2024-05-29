using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Configuration;

namespace ProductDBForm
{
    internal class ContextDB: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server = LAPTOP-BGG69D67;Database = DB_STOR;User Id = sa;Password = 123;");
        }

        public DbSet<ProductEntity> tbProduct { get; set; }
    }   
}
