using _3DPropertiesAPI.Data;
using _3DPropertiesAPI.Dtos;
using _3DPropertiesAPI.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3DPropertiesAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, UserDto>();
            CreateMap<UserRegisterDto, AppUser>();
            CreateMap<PictureDto, Picture>();
            CreateMap<VideoDto, Video>();
        }
    }
}
