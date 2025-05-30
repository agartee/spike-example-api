using Example.WebApp.Handlers;

namespace Example.WebApp.Configuration
{
    public static class DomainServicesConfiguration
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddTransient<GetPeopleHandler>();
            services.AddTransient<GetUserInfoHandler>();

            return services;
        }
    }
}
