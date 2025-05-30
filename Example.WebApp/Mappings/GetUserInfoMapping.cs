using Example.WebApp.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Example.WebApp.Endpoints
{
    public static class GetUserInfoMapping
    {
        public static IEndpointRouteBuilder MapGetUserInfo(this IEndpointRouteBuilder endpoints)
        {
            // note: passed parameters can be mapped in the handler using the [FromBody], [FromQuery], [FromRoute], etc. attributes
            endpoints.MapGet("api/user", ([FromServices] GetUserInfoHandler handler) => handler.Handle()).RequireAuthorization();

            return endpoints;
        }
    }
}
