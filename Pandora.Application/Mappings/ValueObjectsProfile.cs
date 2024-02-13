using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using Pandora.Domain;

namespace Pandora.Application.Mappings
{
    public class ValueObjectsProfile : Profile
    {
        public ValueObjectsProfile()
        {
            CreateMap<UniqueId, Guid>().ConvertUsing(userId => userId.Value);

        }
    }
}
