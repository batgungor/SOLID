using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Infrastructure
{
    public static class ConfigurationSetup
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfigurationRoot configuration)
        {
            var externalServices = new ExternalServicesAppSettings();
            configuration.Bind("ExternalServices", externalServices);

            var userServiceUri = new Uri(externalServices.UserService);
            services.AddHttpClient<UserService>(conf =>
            {
                conf.BaseAddress = userServiceUri;
            });

            var orderServiceUri = new Uri(externalServices.OrderService);
            services.AddHttpClient<OrderService>(conf =>
            {
                conf.BaseAddress = orderServiceUri;
            });

            var campaignServiceUri = new Uri(externalServices.CampaignService);
            services.AddHttpClient<CampaingService>(conf =>
            {
                conf.BaseAddress = campaignServiceUri;
            });
        }
    }
}
