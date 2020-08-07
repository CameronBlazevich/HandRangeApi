using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace PBandJ.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                // .UseSerilog()
                // .ConfigureLogging((hostingContext, logging) =>
                // {
                //     logging.AddApplicationInsights(hostingContext.Configuration["ApplicationInsights:InstrumentationKey"]);
                //     logging.AddFilter<ApplicationInsightsLoggerProvider>("", LogLevel.Trace);
                //     logging.AddFilter<ApplicationInsightsLoggerProvider>("Microsoft", LogLevel.Warning);
                // })
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}