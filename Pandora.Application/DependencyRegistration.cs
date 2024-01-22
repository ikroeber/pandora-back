using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Pandora.Application.Dto;
using Pandora.Application.Mappings;
using Pandora.Application.Services;
using Pandora.Domain.Entities;
using Pandora.Domain.Mappings;

namespace Pandora.Application
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddApplicationRegistrations(this IServiceCollection services)
        {
            services.AddScoped<IMapper<User, UserDto>, UserMapper>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
