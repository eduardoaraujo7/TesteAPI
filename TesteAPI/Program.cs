using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace TesteAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuiler(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuiler(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(c => c.UseStartup<Startup>());
    }
}
