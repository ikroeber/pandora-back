using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using Pandora.Domain;
using Pandora.Infrastructure.Persistence.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;

namespace Pandora.Infrastructure
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddInfrastructureRegistrations(
            this IServiceCollection services)
        {
            services.AddDbContext<PandoraContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
