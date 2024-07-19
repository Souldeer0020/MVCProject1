using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}


//How to create Layout: 1- make a folder named Shared under the folder "Views"
//                      2- right click on "Shared" then add then Layout
//                      3- then inside layout put the main structure that you would like to have in most of your views
//                      4- inside each view you write only just the body and attach the layout with it

//How to create views: 1- create a folder "Views"
//                     2- create a folder for each controller inside "Views"
//                     3- right click on 2 then choose add then view

//How to create a file which will be for th needed imports: 1- using folder views
//                                                          2- right click on the folder then "add new item"
//                                                          3- then we choose Razor view imports
//                                                          4- we add the imports we need