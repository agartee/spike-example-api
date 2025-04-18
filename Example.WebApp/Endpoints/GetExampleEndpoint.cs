using Example.WebApp.Models;

namespace Example.WebApp.Endpoints
{
    public static class GetExampleEndpoint
    {
        public static IEndpointRouteBuilder MapGetExampleRoute(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("api/example", GetExampleData);

            return endpoints;
        }

        public static IEnumerable<Person> GetExampleData(HttpContext httpContext)
        {
            var data = new[]
            {
                new Person { Id = Guid.NewGuid(), FirstName = "John", LastName = "Doe" },
                new Person { Id = Guid.NewGuid(), FirstName = "Jane", LastName = "Doe" },
            };

            return data;
        }
    }
}
