﻿using JWTAuthenticationDemo.Core.DTOs;
using SharedLibrary.Dtos;
using System.Threading.Tasks;

namespace JWTAuthenticationDemo.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
    }
}