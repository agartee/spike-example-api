using Example.WebApp.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Example.WebApp.Endpoints
{
    public static class GetPeopleMapping
    {
        public static IEndpointRouteBuilder MapGetPeople(this IEndpointRouteBuilder endpoints)
        {
            // note: passed parameters can be mapped in the handler using the [FromBody], [FromQuery], [FromRoute], etc. attributes
            endpoints.MapGet("api/example", ([FromServices] GetPeopleHandler handler) => handler.Handle());

            return endpoints;
        }
    }
}
