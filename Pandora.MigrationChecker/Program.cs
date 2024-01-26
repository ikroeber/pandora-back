using Pandora.MigrationChecker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Pandora.Infrastructure;
using System.Reflection;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Pandora.Infrastructure.Persistence.EFCore;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
       .AddInfrastructureRegistrations();

builder.Services.AddTransient<MigrationChecker>();

builder.Services.AddHostedService<MigrationService>();

var app = builder.Build();

await app.StartAsync();

