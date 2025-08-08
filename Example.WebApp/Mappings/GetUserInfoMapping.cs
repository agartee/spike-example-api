using Example.WebApp.Handlers;

namespace Example.WebApp.Endpoints
{
    public static class GetUserInfoMapping
    {
        public static IEndpointRouteBuilder MapGetUserInfo(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("api/user", (GetUserInfoHandler handler) => handler.Handle())
                .RequireAuthorization();

            return endpoints;
        }
    }
}
