using Example.WebApp.Configuration;
using Example.WebApp.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppAuthentication(builder.Configuration);
builder.Services.AddAppAuthorization();

builder.Services.AddAppSwagger();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapGetExampleRoute();

app.Run();
