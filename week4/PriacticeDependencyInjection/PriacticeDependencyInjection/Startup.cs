using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PriacticeDependencyInjection.Controllers;
using PriacticeDependencyInjection.Services;

namespace PriacticeDependencyInjection
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddTransient<UtilityService>();
            services.AddTransient<HomeController>();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
           // app.UseMiddleware<ConsoleLoggerMiddleware>();
        }
    }
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        private readonly IColor printer;
        public ConsoleLoggerMiddleware(IColor printer)
        {
            this.printer = printer;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            //Console.WriteLine("Hi from the middleware");
            printer.PrintColor();
            return next(context);
        }
    }
}
