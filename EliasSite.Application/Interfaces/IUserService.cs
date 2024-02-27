using Elias.Data.DTOs.UserDto;
using Elias.Data.Entities;

namespace Elias.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetUserForAdminAsync();
        Task<bool> DuplicateEmail(int id ,string email);
        Task<bool> DuplicateMobile(int id ,string phoneNumber);
        Task<CreateUserResult> CreateUserAsync(CreateUserDto user);
        Task<UpdateUserDto> FindUserForUpdateAsync(int Id);
        Task<UpdateUserResult> UpdateUser(UpdateUserDto user);
        Task<User> FindUserAsync(int Id);
        Task<User> GetByEmail(string email);
        Task<bool> IsExistUser();
        Task<LoginResult> Login(LoginDto login);
    }
}
