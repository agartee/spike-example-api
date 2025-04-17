using Example.WebApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("api/example", (HttpContext httpContext) =>
{
    var data = new[]
    {
        new Person
        {
            Id = Guid.NewGuid(),
            FirstName = "John",
            LastName = "Doe",
        },
        new Person
        {
            Id = Guid.NewGuid(),
            FirstName = "Jane",
            LastName = "Doe",
        },
    };

    return data;
});

app.Run();
