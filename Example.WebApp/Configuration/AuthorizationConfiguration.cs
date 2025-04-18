using Microsoft.AspNetCore.Authorization;

namespace Example.WebApp.Configuration
{
    public static class AuthorizationConfiguration
    {
        public static IServiceCollection AddAppAuthorization(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
            });

            return services;
        }
    }
}
