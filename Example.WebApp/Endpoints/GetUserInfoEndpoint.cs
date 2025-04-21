using System.Security.Claims;

namespace Example.WebApp.Endpoints
{
    public static class GetUserInfoEndpoint
    {
        public static IEndpointRouteBuilder MapGetUserInfoRoute(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("api/user", GetUserInfo).RequireAuthorization();

            return endpoints;
        }

        public static IEnumerable<Claim> GetUserInfo(HttpContext httpContext)
        {
            var data = httpContext.User.Claims;

            return data;
        }
    }
}
