using Microsoft.EntityFrameworkCore;
using System;
using WebShop.Classes;

namespace WebShopBase
{
    public class ShopContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        { 
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql("User ID=postgres;Password=123;Host=localhost;Port=5432;Database=webshop;Pooling=true;");
        }
    }
}
