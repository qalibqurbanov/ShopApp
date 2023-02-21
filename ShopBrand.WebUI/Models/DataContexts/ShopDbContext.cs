using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
    }

}
