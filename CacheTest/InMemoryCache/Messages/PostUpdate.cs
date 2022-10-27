using Microsoft.Xrm.Sdk;
using System;
using SB.Shared.Models.Dynamics;
using SB.Shared.Services;

namespace CustomSettings.Messages
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

                cachingProvider.SetItem(SBCustomSettingsModel.LogicalName, target, target.GetAttributeValue<double>(SBCustomSettingsModel.Fields.CacheUpdateFrequency));
                //target[SBCustomSettingsModel.Fields.LastRefreshed] = DateTime.Now;
            }
            catch (Exception e)
            {
                throw new InvalidPluginExecutionException(e.Message);
            }
        }
    }
}
