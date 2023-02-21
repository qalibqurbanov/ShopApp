using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopBrand.WebUI.Models.Entities;

namespace ShopBrand.WebUI.Models.DataContexts
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base()
        {

        }

        public ShopDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductColor> Colors { get; set; }
        public DbSet<ProductSize> Sizes { get; set; }
        public DbSet<Category> Categories { get; set; }

    }

}
