using Application.Infrastructure;
using Application;

namespace Scheduler.Infrastructure
{
    public static class ConfigurationSetup
    {
        public static void AddExternalServices(this IServiceCollection services, IConfigurationRoot configuration)
        {
            var externalServices = new ExternalServicesAppSettings();
            configuration.Bind("ExternalServices", externalServices);

            var campaignServiceUri = new Uri(externalServices.CampaignService);
            services.AddHttpClient<CampaingService>(conf =>
            {
                conf.BaseAddress = campaignServiceUri;
            });
        }
    }
}
