using Elias.Application.Interfaces;
using Elias.Data.Context;
using Elias.Data.DTOs.UserDto;
using Elias.Data.Entities;
using Elias.Common;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Net;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;


namespace Elias.Application.Services
{
#nullable disable
    public class UserService : IUserService
    {

        #region Inject DB
        private readonly DatabaseContext _db;
        public UserService(DatabaseContext db)
        {
            _db = db;
        }
        #endregion

        public async Task<CreateUserResult> CreateUserAsync(CreateUserDto user)
        {
            var newuser = new User()
            {
                Address = user.Address,
                City = user.City,
                CreateDate = DateTime.Now.ToShamsi(),
                Email = user.Email.ToLower().Trim(),
                Familly = user.Familly,
                GitHub = user.GitHub,
                IsActive = user.IsActive,
                LinkedIn = user.LinkedIn,
                MainDescription = user.MainDescription,
                MainSkill = user.MainSkill,
                Name = user.Name,
                Ostan = user.Ostan,
                Password =PasswordHelper.EncodePasswordMd5(user.Password),
                PhoneNumber = user.PhoneNumber,
                ShortDescription = user.ShortDescription,
                Skills = user.Skills,
                Skype = user.Skype,
                UserName = user.UserName,
            };

            await _db.AddAsync(newuser);
            await _db.SaveChangesAsync();

            return CreateUserResult.Success;
        }

        public async Task<bool> DuplicateEmail(int id, string email)
        {
            return await _db.Users.AnyAsync(u=> u.Email == email && u.Id != id);
        }

        public async Task<bool> DuplicateMobile(int id, string phoneNumber)
        {
            return await _db.Users.AnyAsync(u => u.PhoneNumber == phoneNumber && u.Id != id);
        }

        public async Task<User> FindUserAsync(int Id)
        {
            var user = await _db.Users.FindAsync(Id);
            return user;
        }

        public async Task<UpdateUserDto> FindUserForUpdateAsync(int Id)
        {
            var findUser = await FindUserAsync(Id);

            return new UpdateUserDto()
            {
                Email = findUser.Email,
                Id = findUser.Id,
                Address = findUser.Address,
                City = findUser.City,
                Familly = findUser.Familly,
                GitHub = findUser.GitHub,
                IsActive = findUser.IsActive,
                LinkedIn = findUser.LinkedIn,
                MainDescription = findUser.MainDescription,
                MainSkill = findUser.MainSkill,
                Name = findUser.Name,
                Ostan = findUser.Ostan,
                Password = findUser.Password,
                PhoneNumber = findUser.PhoneNumber,
                ShortDescription = findUser.ShortDescription,
                Skills = findUser.Skills,
                Skype = findUser.Skype,
                UserName = findUser.UserName,

            };

        }

        public async Task<User> GetByEmail(string email)
        {
            return 
                await _db.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<bool> IsExistUser()
        {
            return await _db.Users.AnyAsync();
        }

        public async Task<LoginResult> Login(LoginDto login)
        {
            var email = login.Email.Trim().ToLower();
            var user = await GetByEmail(email); 
            if (user is null) 
            { 
                return  LoginResult.UserNotFound; 
            }
            string hashPass = PasswordHelper.EncodePasswordMd5(login.Password);
            if ( user.Password != hashPass)
            {
                return LoginResult.UserNotFound;
            }

            return LoginResult.Success;
        }

        public async Task<UpdateUserResult> UpdateUser(UpdateUserDto user)
        {
            if (user is null)
            {
                return UpdateUserResult.UserNotFound;
            }
            if (await DuplicateEmail(user.Id,user.Email.ToLower().Trim()))
            {
                return UpdateUserResult.DuplicateEmail;
            }
            if (await DuplicateMobile(user.Id, user.PhoneNumber))
            {
                return UpdateUserResult.DuplicateMobile;
            }
            _db.Update(user);
            await _db.SaveChangesAsync();
            return UpdateUserResult.Success;
        }
    }
}
