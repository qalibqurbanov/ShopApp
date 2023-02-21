using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopBrand.WebUI.Models.DataContexts;

namespace ShopBrand.WebUI.Extensions.Configuration
{
    public static class RegisterServices
    {
        public static void AddDefaultServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMvc()
                .AddRazorRuntimeCompilation();

            services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ShopSqlConnectionString1")));

        }

        public static void AddCustomServices(this IServiceCollection services)
        {

        }
    }
}