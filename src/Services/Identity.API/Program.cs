using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;

namespace Identity.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Identity.API";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://localhost:5000")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
