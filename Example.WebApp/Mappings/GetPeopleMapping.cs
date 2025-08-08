using Example.WebApp.Handlers;

namespace Example.WebApp.Endpoints
{
    public static class GetPeopleMapping
    {
        public static IEndpointRouteBuilder MapGetPeople(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("api/person", (GetPeopleHandler handler) => handler.Handle());

            return endpoints;
        }
    }
}
