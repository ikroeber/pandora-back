using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Pandora.Application.Mappings;
using Pandora.Application.Services;

namespace Pandora.Application
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddApplicationRegistrations(this IServiceCollection services)
        {
            services.AddAutoMapper(configuration =>
            {
                configuration.AddProfile<ValueObjectsProfile>();
                configuration.AddProfile<UserProfile>();
            });

            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
