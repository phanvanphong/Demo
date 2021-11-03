using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Formatting.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;

namespace DemoDotNet5
{
    public class Program
    {

        public static void Main(string[] args)
        {

            // Truyền cấu hình file log4net.config
            // var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            // XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));


            // Cấu hình serilog
            Log.Logger = new LoggerConfiguration()
                // Đối tượng cấu hình WriteTo
                //.WriteTo.Console()
                // // Định dạng kiểu JSON và tệp nhật ký log.txt
                //.WriteTo.File(new JsonFormatter(), "Logs\\log.txt",
                //    // Quy định level cụ thể ở đây là Infomation
                //    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information,
                //    // Format thời gian
                //    rollingInterval: RollingInterval.Day)
                .WriteTo.File(new JsonFormatter(),"Logs/errorlog.txt",
                    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Error,
                    rollingInterval: RollingInterval.Day)
                .CreateLogger();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                 // Thêm UseSerilog()
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
