using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Dto;

namespace Dto
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<UserDto, Dal.User>();
            CreateMap< Dal.User, UserDto>();
        }
    }
}
