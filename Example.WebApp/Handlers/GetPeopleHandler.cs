﻿using Example.WebApp.Models;

namespace Example.WebApp.Handlers
{
    public class GetPeopleHandler
    {
        private HttpContext httpContext;

        public GetPeopleHandler(IHttpContextAccessor httpContextAccessor)
        {
            httpContext = httpContextAccessor.HttpContext ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public IEnumerable<Person> Handle()
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
