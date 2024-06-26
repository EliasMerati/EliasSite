﻿using Elias.Application.Interfaces;
using Elias.Common;
using Elias.Data.Context;
using Elias.Data.DTOs;
using Elias.Data.DTOs.UserDto;
using Elias.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace Elias.Application.Services
{
#nullable disable
    public class UserService : IUserService
    {

        #region Inject DB
        private readonly DatabaseContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;
        public UserService(DatabaseContext db, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
        }
        #endregion


        #region User Services
        public async Task<CreateUserResult> CreateUserAsync(CreateUserDto user, IFormFile Image, IFormFile Resumeh)
        {

            var newuser = new User()
            {
                Address = user.Address,
                City = user.City,
                CreateDate = DateTime.Now,
                Email = user.Email.ToLower().Trim(),
                Familly = user.Familly,
                GitHub = user.GitHub,
                IsActive = user.IsActive,
                LinkedIn = user.LinkedIn,
                MainDescription = user.MainDescription,
                MainSkill = user.MainSkill,
                Name = user.Name,
                Ostan = user.Ostan,
                Password = PasswordHelper.EncodePasswordMd5(user.Password),
                PhoneNumber = user.PhoneNumber,
                ShortDescription = user.ShortDescription,
                Skills = user.Skills,
                Skype = user.Skype,
                UserName = user.UserName,
            };
            await SetProfilePicUser(newuser, Image);
            await SetResumehUser(newuser, Resumeh);
            await _db.AddAsync(newuser);
            await _db.SaveChangesAsync();

            return CreateUserResult.Success;
        }
        public async Task<bool> DuplicateEmail(int id, string email)
        {
            return await _db.Users.AnyAsync(u => u.Email == email && u.Id != id);
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
        public async Task<User> FindUserForUpdateAsync(int Id)
        {
            return await FindUserAsync(Id);
        }
        public async Task<User> GetByEmail(string email)
        {
            return
                await _db.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
        public async Task<List<UserDto>> GetUserForAdminAsync()
        {
            return await _db.Users.Select(p => new UserDto
            {
                Familly = p.Familly,
                MainSkill = p.MainSkill,
                Name = p.Name,
                PhoneNumber = p.PhoneNumber,
                UserName = p.UserName,
                Id = p.Id,
            }).ToListAsync();
        }
        public async Task<bool> IsExistUser()
        {
            return await _db.Users.AnyAsync();
        }

       
        public User Login(LoginDto login)
        {
            string email = login.Email;
            string hashPass = PasswordHelper.EncodePasswordMd5(login.Password); 
            return _db.Users.SingleOrDefault(u => u.Email == email && u.Password == hashPass);
        }
        public async Task UpdateUser(User user, IFormFile Image, IFormFile Resumeh)
        {
            user.CreateDate = DateTime.Now;
            await UpdatePicUser(user, Image);
            await UpdateResumehUser(user, Resumeh);
            _db.Update(user);
            await _db.SaveChangesAsync();
        }
        #endregion

        #region Insert&Update Resumeh - ProfilePic
        private async Task SetProfilePicUser(User user, IFormFile Image)
        {
            if (Image is not null)
            {
                if (user.UserImage is null)
                {

                    user.UserImage = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                    string Imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProfilePic/", user.UserImage);
                    using (var stream = new FileStream(Imagepath, FileMode.CreateNew))
                    {

                        Image.CopyTo(stream);
                    }
                }
                else
                {
                    string DeleteDemoPath = "";
                    DeleteDemoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProfilePic/", user.UserImage);
                    if (File.Exists(DeleteDemoPath))
                    {
                        File.Delete(DeleteDemoPath);
                    }

                    user.UserImage = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                    DeleteDemoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProfilePic/", user.UserImage);
                    using (var stream = new FileStream(DeleteDemoPath, FileMode.CreateNew))
                    {

                        Image.CopyTo(stream);
                    }
                }
            }
        }
        private async Task UpdatePicUser(User user, IFormFile Image)
        {
            if (Image is not null)
            {
                if (user.UserImage is null)
                {
                    user.UserImage = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                    string Imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProfilePic/", user.UserImage);
                    using (var stream = new FileStream(Imagepath, FileMode.CreateNew))
                    {

                        Image.CopyTo(stream);
                    }
                }
                else
                {
                    string ImagePath = "";
                    ImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProfilePic/", user.UserImage);
                    if (File.Exists(ImagePath))
                    {
                        File.Delete(ImagePath);
                    }

                    user.UserImage = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                    ImagePath = Path.Combine(Directory.GetCurrentDirectory() , "wwwroot/ProfilePic/", user.UserImage);
                    using (var stream = new FileStream(ImagePath, FileMode.CreateNew))
                    {

                        Image.CopyTo(stream);
                    }
                }
            }
        }
        private async Task UpdateResumehUser(User user, IFormFile Resumeh)
        {
            if (Resumeh is not null)
            {
                if (user.Resumeh is null)
                {
                    user.Resumeh = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Resumeh.FileName);
                    string Resumehpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Resumeh/", user.Resumeh);
                    using (var stream = new FileStream(Resumehpath, FileMode.CreateNew))
                    {

                        Resumeh.CopyTo(stream);
                    }
                }
                else
                {
                    var DeleteResumehPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Resumeh/", user.Resumeh);
                    if (File.Exists(DeleteResumehPath))
                    {
                        File.Delete(DeleteResumehPath);
                    }

                    user.Resumeh = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Resumeh.FileName);
                    string Imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Resumeh/", user.Resumeh);
                    using (var stream = new FileStream(Imagepath, FileMode.CreateNew))
                    {

                        Resumeh.CopyTo(stream);
                    }
                }
            }
        }
        private async Task SetResumehUser(User user, IFormFile Resumeh)
        {
            if (Resumeh is not null)
            {
                if (user.Resumeh is null)
                {
                    user.Resumeh = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Resumeh.FileName);
                    string Resumehpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Resumeh/", user.Resumeh);
                    using (var stream = new FileStream(Resumehpath, FileMode.CreateNew))
                    {

                        Resumeh.CopyTo(stream);
                    }
                }
                else
                {
                    var DeleteResumehPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Resumeh/", user.Resumeh);
                    if (File.Exists(DeleteResumehPath))
                    {
                        File.Delete(DeleteResumehPath);
                    }

                    user.Resumeh = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Resumeh.FileName);
                    string Imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Resumeh/", user.Resumeh);
                    using (var stream = new FileStream(Imagepath, FileMode.CreateNew))
                    {

                        Resumeh.CopyTo(stream);
                    }
                }
            }
        }
        #endregion

        #region Password Services
        private async Task<string> HashPassword(string password)
        {
            return PasswordHelper.EncodePasswordMd5(password);
        }
        public async void ChangeNewPassword(string username, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.UserName == username);
            user.Password = await HashPassword(password);
            _db.Users.Update(user);
            _db.SaveChanges();
        }
        public async Task<bool> CompareOldPassword(string password, string username)
        {
            var HashPass = await HashPassword(password);
            return _db.Users.Any(u => u.UserName == username && u.Password == HashPass);
        }
        #endregion

        #region AboutMe Services
        public async Task<AboutMeInfoDto> GetAboutMeInfo()
        {
            return await _db.Users.Select(u => new AboutMeInfoDto()
            {
                BirthDay = u.BirthDay,
                City = u.City,
                Email = u.Email,
                Familly = u.Familly,
                MainDescription = u.MainDescription,
                MainSkill = u.MainSkill,
                Name = u.Name,
                PhoneNumber = u.PhoneNumber,
                Skype = u.Skype,
            }).SingleAsync();
        }
        public async Task<SocialDto> GetSocialInfo()
        {
            return await _db.Users.Select(u => new SocialDto()
            {
                GitHub = u.GitHub,
                LinkedIn = u.LinkedIn,
                Skype = u.Skype,
            }).SingleAsync();
        }
        public async Task<MainInfoDto> GetMainInfo()
        {
            return await _db.Users.Select(u => new MainInfoDto()
            {
                Familly = u.Familly,
                Name = u.Name,
                Skills = u.Skills,
            }).SingleAsync();
        }
        public HeaderDto GetHeaderInfo()
        {
            return  _db.Users.Select(u => new HeaderDto()
            {
                Familly = u.Familly,
                Name = u.Name,
                MainSkill = u.MainSkill,
                UserImage = u.UserImage,
            }).Single();
        }

        public ResumehDto GetResumeh()
        {
            return _db.Users.Select(r => new ResumehDto()
            {
                Resumeh = r.Resumeh,
            }).Single();
        }

        public async Task<ContactMeAddressDto> GetContactMeAddressInfo()
        {
            return _db.Users.Select(u => new ContactMeAddressDto()
            {
                Address = u.Address,
                City = u.City,
                Email = u.Email,
                Ostan = u.Ostan,
                PhoneNumber = u.PhoneNumber,
                Skype = u.Skype,
            }).AsNoTracking().Single();
        }
        #endregion

    }
}
