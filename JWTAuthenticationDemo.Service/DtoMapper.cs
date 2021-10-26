using AutoMapper;
using JWTAuthenticationDemo.Core.DTOs;
using JWTAuthenticationDemo.Core.Models;

namespace JWTAuthenticationDemo.Service
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}
