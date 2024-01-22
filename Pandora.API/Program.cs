using Microsoft.EntityFrameworkCore;

using Pandora.API.Startup.Swagger;
using Pandora.Application;
using Pandora.Infrastructure;

using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(config =>
{
    config.SchemaFilter<DtoNameFilter>();
});

builder.Services.AddApplicationRegistrations();

builder.Services
       .AddInfrastructureRegistrations(
            builder.Configuration.GetConnectionString("pandora-db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
