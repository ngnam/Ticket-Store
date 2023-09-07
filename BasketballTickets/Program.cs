using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BasketballTickets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            //https://dotnetcoretutorials.com/using-user-secrets-configuration-in-net/?expand_article=1
            return WebHost.CreateDefaultBuilder(args)
               .ConfigureAppConfiguration((hostingContext, config) =>
               {
                   var env = hostingContext.HostingEnvironment;

                   if (env.IsDevelopment())
                   {
                       config
                        .SetBasePath(env.ContentRootPath)
                        .AddJsonFile("appsettings.json", true, true)
                        .AddJsonFile($"appsettings.Development.json", true, true)
                        .AddJsonFile($"appsettings.{Environment.UserName}.json", true, true)
                        .AddJsonFile("secrets.json", optional: true, reloadOnChange: true)
                        //.AddUserSecrets(Assembly.GetExecutingAssembly(), true)
                        .AddEnvironmentVariables()
                        .Build();
                   }
                   else
                   {
                       config
                        .SetBasePath(env.ContentRootPath)
                        .AddJsonFile("appsettings.json", true, true)
                        .AddJsonFile($"appsettings.Development.json", true, true)
                        .AddJsonFile($"appsettings.{Environment.UserName}.json", true, true)
                        .AddEnvironmentVariables()
                        .Build();
                   }

               })
               .UseStartup<Startup>();

        }


    }
}
