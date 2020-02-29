namespace SiteCheker
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Serilog;
    using Serilog.Events;
    using System.Configuration.Install;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.ServiceProcess;

    /// <summary>
    /// Defines the <see cref="Program" />
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The Main
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/></param>
        public static void Main(string[] args)
        {
            string arg = args.Count() != 0 ? args[0]:null; //string.Concat(args);
            var location = Assembly.GetExecutingAssembly().Location;
            switch (arg)
            {
                case "--install":
                    Install("Site Checking Service", location);
                    break;
                case "--uninstall":
                    UnInstall("Site Checking Service", location);
                    break;
                default:
                    Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.File(@"C:\temp\workerlog\log.txt")
                .CreateLogger();
                    try
                    {
                        Log.Information("Starting Up Service");
                        CreateHostBuilder(args).Build().Run();
                        return;
                    }
                    finally
                    {
                        Log.CloseAndFlush();
                    }
                    break;
            }
        }

        /// <summary>
        /// The Install
        /// </summary>
        /// <param name="Source">The Source<see cref="string"/></param>
        /// <param name="location">The location<see cref="string"/></param>
        public static void Install(string Source, string location)
        {
            ManagedInstallerClass.InstallHelper(new[] { location });
            StartService(Source);
        }

        /// <summary>
        /// The UnInstall
        /// </summary>
        /// <param name="Source">The Source<see cref="string"/></param>
        /// <param name="location">The location<see cref="string"/></param>
        public static void UnInstall(string Source, string location)
        {
            Process.GetProcessesByName(Source).Where(proc => proc.Id != Process.GetCurrentProcess().Id).FirstOrDefault()?.Kill();
            ManagedInstallerClass.InstallHelper(new[] { "/u", location });
        }

        /// <summary>
        /// The StartService
        /// </summary>
        /// <param name="serviceName">The serviceName<see cref="string"/></param>
        public static void StartService(string serviceName)
        {
            ServiceController controller = new ServiceController(serviceName);
            if (controller.Status == ServiceControllerStatus.Stopped)
                controller.Start();
        }

        /// <summary>
        /// The CreateHostBuilder
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/></param>
        /// <returns>The <see cref="IHostBuilder"/></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseWindowsService()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                })
                .UseSerilog();
    }
}
