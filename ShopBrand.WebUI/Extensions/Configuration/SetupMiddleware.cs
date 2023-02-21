using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace ShopBrand.WebUI.Extensions.Configuration
{
    public static class SetupMiddleware
    {
        public static void AddDefaultMiddlewares(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/coming-soon.html", async (context) =>
                {
                    using (StreamReader SR = new StreamReader("views/static/coming-soon.html"))
                    {
                        context.Response.ContentType = "text/html";
                        await context.Response.WriteAsync(await SR.ReadToEndAsync());
                    }
                });

                endpoints.MapControllerRoute
                (
                    name: "areas1",
                    pattern: "{controller=Shop}/{action=Index}"
                );

                endpoints.MapRazorPages();
            });
        }
    }
}