using DataService.Models;
using EOD_ClientEmail.Service;
using EOD_ClientEmail;
using EOD_RmCxoAndClientEmail;

public class Program
{
    public static async Task Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                // Register hosted service
                services.AddHostedService<Worker>();

                // Register application-specific services
                services.AddScoped<IEODClientEmailservice, EODClientEmailservice>();
                services.AddScoped<NeoNexusBrsContext>();
                services.AddSingleton<IErrorLogService, ErrorLogService>();

                // Register configuration for dependency injection
                services.AddSingleton<IConfiguration>(context.Configuration);
            })
            .UseWindowsService() // Configure to run as a Windows Service
            .Build();

        await host.RunAsync();
    }
}
