using Microsoft.Crm.Sdk.Messages;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Triggered_WebJob1
{
    class Worker : BackgroundService
    {
        private readonly IOrganizationService _crmService;
        private readonly ILogger<Worker> _logger;

        public Worker(IOrganizationService crmService, ILogger<Worker> logger)
        {
            _crmService = crmService;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker is starting.");

            var response = (WhoAmIResponse)_crmService.Execute(new WhoAmIRequest());
            Console.WriteLine(response.UserId.ToString());

            _logger.LogInformation("Worker background task is stopping.");
        }
    }
}
