﻿using Elias.Data.DTOs;
using Elias.Data.DTOs.UserDto;
using Elias.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace Elias.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetUserForAdminAsync();
        Task<bool> DuplicateEmail(int id ,string email);
        Task<bool> DuplicateMobile(int id ,string phoneNumber);
        Task<CreateUserResult> CreateUserAsync(CreateUserDto user , IFormFile Image , IFormFile Resumeh);
        Task<User> FindUserForUpdateAsync(int Id);
        Task UpdateUser(User user, IFormFile Image, IFormFile Resumeh);
        Task<User> FindUserAsync(int Id);
        Task<User> GetByEmail(string email);
        Task<bool> IsExistUser();
        User Login(LoginDto login);
        void ChangeNewPassword(string username, string password);
        Task<bool> CompareOldPassword(string password, string username);
        Task<AboutMeInfoDto> GetAboutMeInfo();
        Task<SocialDto> GetSocialInfo();
        Task<MainInfoDto> GetMainInfo();
        HeaderDto GetHeaderInfo();
        Task<ContactMeAddressDto> GetContactMeAddressInfo();
        ResumehDto GetResumeh();
    }
}
