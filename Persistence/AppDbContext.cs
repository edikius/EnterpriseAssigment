using ItemStoreProject.Persistence.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ItemStoreProject.Persistence
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> AspNetUsers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<ItemType> ItemType { get; set; }
        public AppDbContext() : base()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}