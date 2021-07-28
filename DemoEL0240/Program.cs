using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.AzureAppServices;

namespace DemoEL0240
{
    public class Program
    {
        public static Dictionary<string, string> dictEmployees { get; } = new Dictionary<string, string>
        {
                {"Asia:employees:1", "Mary"},
                {"Asia:employees:2", "John"},
                {"Asia:employees:3", "Kevin"},
                {"Asia:employees:4", "David"},
                {"Asia:employees:5", "Rose"}
        };
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                //設定 ContentRoot 路徑
                //.UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureHostConfiguration(configHost =>
                {
                    //設定基底路徑
                    configHost.SetBasePath(Directory.GetCurrentDirectory());

                    //configHost有Properties和Sources兩個屬性,前者是Key(FileProvide)及Value(PhysicalFileProvide),後者是Providers提供者資訊
                    //如想看見SetBasePath()設定後路徑,可用下面程式抓取
                    string contentRoot = ((Microsoft.Extensions.FileProviders.PhysicalFileProvider)configHost.Properties.Values.FirstOrDefault()).Root;

                    configHost.AddJsonFile("hostsettings.json", optional: true);
                    configHost.AddEnvironmentVariables(prefix: "PREFIX_");
                    configHost.AddCommandLine(args);

                })
                .ConfigureAppConfiguration((hostingContext, configApp) =>
                {
                    //configApp.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"), true, true);

                    //設定組能檔完整路徑
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "ConfigFiles");
                    configApp.AddJsonFile(Path.Combine(path, "FutureCorp.json"), optional: true, reloadOnChange: true);  //載入自訂JSON組態檔
                    configApp.AddIniFile(Path.Combine(path, "Mobile.ini"), true, true);      //載入自訂INI組態檔
                    configApp.AddXmlFile(Path.Combine(path, "Computer.xml"), true, true);    //載入自訂XML組態檔
                    configApp.AddJsonFile(Path.Combine(path, "Device.json"), true, true);   //載入自訂JSON組態檔

                    path = Path.Combine(Directory.GetCurrentDirectory(), "Configuration");
                    configApp.AddJsonFile(Path.Combine(path, "Food.json"), true, true);
                    configApp.AddInMemoryCollection(dictEmployees);
                })
                #region 設定 Logging 提供者
                .ConfigureLogging(loggingBuilder =>
                {
                    loggingBuilder.ClearProviders();
                    #region 系統預設提供者
                    loggingBuilder.AddConsole();
                    loggingBuilder.AddDebug();
                    loggingBuilder.AddEventSourceLogger();
                    #endregion
                    #region 加入其他提供者
                    loggingBuilder.AddEventLog();
                    loggingBuilder.AddTraceSource(new SourceSwitch("loggingSwitch", "Verbose"), new TextWriterTraceListener("LoggingService.txt"));
                    loggingBuilder.AddAzureWebAppDiagnostics();
                    loggingBuilder.AddApplicationInsights();
                    #endregion
                })
                #endregion
                .ConfigureLogging(logging => logging.AddAzureWebAppDiagnostics())
                    .ConfigureServices(serviceCollection => serviceCollection
                        .Configure<AzureFileLoggerOptions>(options =>
                        {
                            options.FileName = "azure-diagnostics-";
                            options.FileSizeLimit = 50 * 1024;
                            options.RetainedFileCountLimit = 5;
                        }).Configure<AzureBlobLoggerOptions>(options =>
                        {
                            options.BlobName = "log.txt";
                        })
                    )
        #region ContentRoot 和 WebRoot 路徑調整可在
            //1. CreateDefaultBuilder方法中，用UserContentRoot 和 UseWebRoot 方法指定路徑參數
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
                //設定 ContentRoot 路徑 ， 路徑參數："/publicshare/"
                //webBuilder.UseWebRoot(Directory.GetCurrentDirectory() + "/publicshare/");
            });
        #endregion

    }
}
