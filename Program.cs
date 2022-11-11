using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RabbitMQClient.Interfaces;

namespace RabbitMQClient
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            var host = Host.CreateDefaultBuilder()
                      .ConfigureAppConfiguration((context, builder) =>
                      {
                          // Add other configuration files...
                          builder.AddJsonFile("appsettings.local.json", optional: true);
                      })
                      .ConfigureServices((context, services) =>
                      {
                          ConfigureServices(context.Configuration, services);
                      })
                      .ConfigureLogging(logging =>
                      {
                          // Add other loggers...
                      })
                      .Build();

            var services = host.Services;
            var mainForm = services.GetRequiredService<RabbitMQClient>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IRabbitMQConfigurations, RabbitMQConfigurations>();
            services.AddScoped<IRabbitMQbroker, RabbitMQbroker>();
            services.AddScoped<IRabbitMQReader, RabbitMQReader>();
            services.AddSingleton<RabbitMQClient>();
        }
    }
}