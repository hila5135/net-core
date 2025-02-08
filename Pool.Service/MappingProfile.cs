using AutoMapper;
using Pool.Core.Dtos;
using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Activity, ActivityPostDTO>().ReverseMap();
            CreateMap<Activity, ActivityPutDTO>().ReverseMap();

        }
    }
}
