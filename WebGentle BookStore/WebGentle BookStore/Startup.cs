using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Data;
using WebGentle_BookStore.Data;

namespace WebGentle_BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookStoredbContext>(
                options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Bookstore;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting(); 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
               /* endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "BookApp/{controller=Home}/{action=Index}/{id?}"); */

        });
        }
    }
}
