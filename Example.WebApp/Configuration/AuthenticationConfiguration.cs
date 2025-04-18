using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Example.WebApp.Configuration
{
    public static class AuthenticationConfiguration
    {
        public static IServiceCollection AddAppAuthentication(this IServiceCollection services, IConfiguration config)
        {
            var authConfig = config.GetSection("Authentication");
            var authority = authConfig["Authority"];
            var clientId = authConfig["ClientId"];

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = authority;
                    options.Audience = clientId;

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        NameClaimType = "name"
                    };
                });

            return services;
        }
    }
}
