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
            var audience = authConfig["Audience"];
            var validIssuer = authConfig["ValidIssuer"];
            var nameClaimType = authConfig["NameClaimType"] ?? "name";

            if (string.IsNullOrWhiteSpace(authority))
                throw new InvalidOperationException("Authentication.Authority is required.");

            if (string.IsNullOrWhiteSpace(audience))
                throw new InvalidOperationException("Authentication.Audience is required.");

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = authority;
                    options.Audience = audience;

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        NameClaimType = nameClaimType
                    };

                    if (!string.IsNullOrWhiteSpace(validIssuer))
                    {
                        options.TokenValidationParameters.ValidIssuer = validIssuer;
                    }
                });

            return services;
        }
    }
}
