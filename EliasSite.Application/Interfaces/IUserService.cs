using Elias.Data.DTOs.UserDto;
using Elias.Data.Entities;

namespace Elias.Application.Interfaces
{
    public interface IUserService
    {
        Task<bool> DuplicateEmail(int id ,string email);
        Task<bool> DuplicateMobile(int id ,string phoneNumber);
        Task<CreateUserResult> CreateUserAsync(CreateUserDto user);
        Task<UpdateUserDto> FindUserForUpdateAsync(int Id);
        Task<UpdateUserResult> UpdateUser(UpdateUserDto user);
        Task<User> FindUserAsync(int Id);
    }
}
