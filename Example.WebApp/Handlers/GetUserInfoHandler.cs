using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Example.WebApp.Handlers
{
    public class GetUserInfoHandler
    {
        private HttpContext httpContext;

        public GetUserInfoHandler(IHttpContextAccessor httpContextAccessor)
        {
            httpContext = httpContextAccessor.HttpContext ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public IResult Handle()
        {
            var claims = httpContext.User.Claims
                .Select(c => new { c.Type, c.Value })
                .ToList();

            return Results.Ok(claims);
        }
    }
}
