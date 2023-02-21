using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopBrand.WebUI.Extensions.Configuration;

namespace ShopBrand.WebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDefaultServices(Configuration);
            services.AddCustomServices();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.AddDefaultMiddlewares(env);
        }
    }
}
