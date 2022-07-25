using LearnSharp4.SerilogLibrary.Services;
using LearnSharp4.SerilogLibrary.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.IO;

namespace LearnSharp4.SerilogLibrary
{
    internal class Program
    {
        public static void Main()
        {
            var builder = new ConfigurationBuilder();
            BuildConfiguration(builder);

            Log.Logger = new LoggerConfiguration()
                                .MinimumLevel.Debug()
                                .ReadFrom.Configuration(builder.Build())
                                .WriteTo.Console()
                                .WriteTo.File("logging.txt",
                                outputTemplate: "{Timestamp:dd-MM-yyyy HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}").CreateLogger();
            Log.Information("Starting console application!");
            var host = Host.CreateDefaultBuilder()
                           .ConfigureServices((context, services) => {
                               services.AddTransient<IGreetingService, GreetingService>();
                           })
                           .UseSerilog().Build();

            var service = ActivatorUtilities.CreateInstance<GreetingService>(host.Services);
            service.Run();

            Log.CloseAndFlush();
        }

        private static void BuildConfiguration(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        }
    }






    // IConfigurationBuilder.AddJsonFile - https://docs.microsoft.com/ru-ru/dotnet/api/microsoft.extensions.configuration.jsonconfigurationextensions.addjsonfile?view=dotnet-plat-ext-6.0
}
