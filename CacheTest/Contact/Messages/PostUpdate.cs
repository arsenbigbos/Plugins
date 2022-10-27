using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using SB.Shared.Models.Dynamics;
using SB.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Messages
{
    public class PostUpdate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var tracer = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            var context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            var factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            var service = factory.CreateOrganizationService(context.UserId);
            var cachingProvider = new CachingProvider();

            try
            {
                var target = (Entity)context.InputParameters["Target"];
                
                var settings = (Entity)cachingProvider.GetItem(SBCustomSettingsModel.LogicalName); //if na 0
                // ne get a get or set
                // if 0 retview na custom setting

                var request = new ExecuteWorkflowRequest
                {
                    EntityId = target.Id,
                    WorkflowId = settings.Id,
                };
                service.Execute(request);
            }
            catch (Exception e)
            {
                throw new InvalidPluginExecutionException(e.Message);
            }
        }
    }
}
