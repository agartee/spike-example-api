using Example.WebApp.Configuration;
using Example.WebApp.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppAuthentication(builder.Configuration);
builder.Services.AddAppAuthorization();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddAppSwagger();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapGetExampleRoute();

app.Run();
