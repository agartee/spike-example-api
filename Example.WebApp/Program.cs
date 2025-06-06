using Example.WebApp.Configuration;
using Example.WebApp.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
builder.Services.AddDomainServices();
builder.Services.AddAppAuthentication(builder.Configuration);
builder.Services.AddAppAuthorization();
builder.Services.AddAppCors();

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

//app.UseHttpsRedirection();

app.MapGetPeople();
app.MapGetUserInfo();

app.Run();
