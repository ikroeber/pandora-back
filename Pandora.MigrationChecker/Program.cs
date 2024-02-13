using Pandora.MigrationChecker;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Pandora.Infrastructure;
using Pandora.Infrastructure.Persistence.EFCore;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
       .AddInfrastructureRegistrations();

builder.Services.AddTransient<MigrationChecker>();

builder.Services.AddHostedService<MigrationService>();

var app = builder.Build();

await app.StartAsync();

