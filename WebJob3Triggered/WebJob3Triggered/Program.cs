using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;

namespace Triggered_WebJob1
{
    class Program
    {
        static void Main()
        {
            var host = new HostBuilder()
                .ConfigureAppConfiguration((hostContext, config) =>
                {
                    config.AddEnvironmentVariables();

                    config.AddUserSecrets<Program>();
                    var settings = config.Build();

                    config.AddAzureConfiguration(settings["ConnectionStrings::AppConfiguration"]);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddLogging();
                    services.AddScoped<IOrganizationService>(provider =>
                        new CrmServiceClient(
                            hostContext.Configuration.GetConnectionString("CRMConnectionString")));
                    services.AddScoped<IHostedService, Worker>();
                })
                .Build();
            host.Start();
        }
    }
}
