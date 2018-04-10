﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace mysample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                // .ConfigureLogging((context, loggerFactory) => {
                //     loggerFactory.AddConfiguration(context.Configuration);
                //     loggerFactory.AddConsole();
                //     loggerFactory.AddDebug();
                // })
                // .ConfigureAppConfiguration((context,configureDelegate) =>{
                //     configureDelegate.AddJsonFile("appsettings.json");
                //     configureDelegate.AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", optional:true);
                //     // if(context.HostingEnvironment.IsDevelopment())
                //     // {
                //     //     configureDelegate.AddJsonFile("appsettings.Development.json");
                //     // }
                // })
                .Build();
    }
}
