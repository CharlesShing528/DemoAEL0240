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
                //�]�w ContentRoot ���|
                //.UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureHostConfiguration(configHost =>
                {
                    //�]�w�򩳸��|
                    configHost.SetBasePath(Directory.GetCurrentDirectory());

                    //configHost��Properties�MSources����ݩ�,�e�̬OKey(FileProvide)��Value(PhysicalFileProvide),��̬OProviders���Ѫ̸�T
                    //�p�Q�ݨ�SetBasePath()�]�w����|,�i�ΤU���{�����
                    string contentRoot = ((Microsoft.Extensions.FileProviders.PhysicalFileProvider)configHost.Properties.Values.FirstOrDefault()).Root;

                    configHost.AddJsonFile("hostsettings.json", optional: true);
                    configHost.AddEnvironmentVariables(prefix: "PREFIX_");
                    configHost.AddCommandLine(args);

                })
                .ConfigureAppConfiguration((hostingContext, configApp) =>
                {
                    //configApp.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"), true, true);

                    //�]�w�կ��ɧ�����|
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "ConfigFiles");
                    configApp.AddJsonFile(Path.Combine(path, "FutureCorp.json"), optional: true, reloadOnChange: true);  //���J�ۭqJSON�պA��
                    configApp.AddIniFile(Path.Combine(path, "Mobile.ini"), true, true);      //���J�ۭqINI�պA��
                    configApp.AddXmlFile(Path.Combine(path, "Computer.xml"), true, true);    //���J�ۭqXML�պA��
                    configApp.AddJsonFile(Path.Combine(path, "Device.json"), true, true);   //���J�ۭqJSON�պA��

                    path = Path.Combine(Directory.GetCurrentDirectory(), "Configuration");
                    configApp.AddJsonFile(Path.Combine(path, "Food.json"), true, true);
                    configApp.AddInMemoryCollection(dictEmployees);
                })
                #region �]�w Logging ���Ѫ�
                .ConfigureLogging(loggingBuilder =>
                {
                    loggingBuilder.ClearProviders();
                    #region �t�ιw�]���Ѫ�
                    loggingBuilder.AddConsole();
                    loggingBuilder.AddDebug();
                    loggingBuilder.AddEventSourceLogger();
                    #endregion
                    #region �[�J��L���Ѫ�
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
        #region ContentRoot �M WebRoot ���|�վ�i�b
            //1. CreateDefaultBuilder��k���A��UserContentRoot �M UseWebRoot ��k���w���|�Ѽ�
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
                //�]�w ContentRoot ���| �A ���|�ѼơG"/publicshare/"
                //webBuilder.UseWebRoot(Directory.GetCurrentDirectory() + "/publicshare/");
            });
        #endregion

    }
}
