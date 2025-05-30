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

        public IEnumerable<Claim> Handle()
        {
            return httpContext.User.Claims;
        }
    }
}
