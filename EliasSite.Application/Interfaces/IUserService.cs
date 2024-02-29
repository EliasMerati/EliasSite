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
        Task<UpdateUserDto> FindUserForUpdateAsync(int Id);
        Task<UpdateUserResult> UpdateUser(UpdateUserDto user, IFormFile Image, IFormFile Resumeh);
        Task<User> FindUserAsync(int Id);
        Task<User> GetByEmail(string email);
        Task<bool> IsExistUser();
        Task<LoginResult> Login(LoginDto login);
        void ChangeNewPassword(string username, string password);
        Task<bool> CompareOldPassword(string password, string username);
    }
}
