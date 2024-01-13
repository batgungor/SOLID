using Application.Infrastructure;
using Application;

namespace API.Infrastructure
{
    public static class ConfigurationSetup
    {
        public static void AddExternalServices(this IServiceCollection services, IConfigurationRoot configuration)
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
        }
    }
}
