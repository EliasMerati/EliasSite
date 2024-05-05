using Elias.Data.Entities;
using Elias.Data.Entities.Blog;
using Elias.Data.Entities.Certificate;
using Elias.Data.Entities.Comment;
using Elias.Data.Entities.Education;
using Elias.Data.Entities.Experience;
using Elias.Data.Entities.Permission;
using Elias.Data.Entities.Portfolio;
using Elias.Data.Entities.Skills;
using Microsoft.EntityFrameworkCore;

namespace Elias.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        #region User
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        #endregion

        #region Skill
        public DbSet<SkillGroup> SkillGroups { get; set; }
        public DbSet<Skill> Skills { get; set; }
        #endregion

        #region Experience
        public DbSet<Experience> Experiences { get; set; }
        #endregion

        #region Education
        public DbSet<Education> Educations { get; set; }
        #endregion

        #region Certificate
        public DbSet<Certificate> Certificates { get; set; }
        #endregion

        #region Portfolio
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioGroup> PortfolioGroups { get; set; }
        public DbSet<PortfolioImages> PortfolioImages { get; set; }
        #endregion

        #region Blog
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogGroup> BlogGroups { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        #endregion

        #region Comment
        public DbSet<Comment> Comments { get; set; }
        #endregion

        #region Permission
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        #endregion
        private void SeedData(ModelBuilder modelBuilder)
        {
            #region Admin
            modelBuilder.Entity<Role>()
                .HasData(new { Id = 1, RoleTitle = "Admin" , CreateDate = DateTime.Now });
            #endregion

            #region User
            modelBuilder.Entity<User>()
              .HasData(new
              {
                  Id = 1,
                  RoleId = 1,
                  UserName = "EliasAdmin",
                  CreateDate = DateTime.Now,
                  Name = "الیاس",
                  Familly = "مرآتی",
                  BirthDay = "1362/06/30",
                  Email = "elias.merati@gmail.com",
                  Password = "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70",
                  Ostan = "خراسان رضوی",
                  UserImage = "Null",
                  City = "نیشابور",
                  Address = "خیابان امیر کبیر - امیر کبیر 9/5 - پلاک 141",
                  ShortDescription = "برنامه نویس دات نت با بیش از 5 سال سابقه ی برنامه نویسی وب و دسکتاپ",
                  MainDescription = "با بیش از 5 سال تجربه در کدنویسی و توسعه ی برنامه های NET. من یک برنامه نویس هوشمند و خلاق هستم.من مسلط به زبان برنامه نویسی #C هستم و توانایی توسعه ی برنامه های تحت وب و دسکتاپ را دارم. من در ایجاد برنامه های کاربردی و کیفیت بالا تخصص دارم و توانایی مشارکت در تیم را به خوبی میدانم. همچنین من با استفاده از فریمورک های مختلفی مانند  ASP .NET MVC,ASP .NET,ASP.NET CORE, ASP.NET RAZORPAGES آشنایی کامل دارم.من متعهد به اهداف شرکت و ارا یه ی راه حل های برتر هستم.",
                  MainSkill = ".Net Developer",
                  Skills = "C# , Asp .Net MVC , Asp .Net RazorPages , Asp .Net CoreMVC , Blazor",
                  GitHub = "https://github.com/EliasMerati",
                  LinkedIn = "https://www.linkedin.com/in/elias-merati",
                  PhoneNumber = "09223610626",
                  Skype = "Elias Merati",
                  IsActive = true,
              });
            #endregion

            #region Role Permissions
            modelBuilder.Entity<RolePermission>()
      .HasData(new { Id = 1, RoleId = 1, PermissionId = 1 , CreateDate = DateTime.Now },
               new { Id = 2, RoleId = 1, PermissionId = 2, CreateDate = DateTime.Now },
               new { Id = 3, RoleId = 1, PermissionId = 3, CreateDate = DateTime.Now },
               new { Id = 4, RoleId = 1, PermissionId = 4, CreateDate = DateTime.Now },
               new { Id = 5, RoleId = 1, PermissionId = 5, CreateDate = DateTime.Now },
               new { Id = 6, RoleId = 1, PermissionId = 6, CreateDate = DateTime.Now },
               new { Id = 7, RoleId = 1, PermissionId = 7, CreateDate = DateTime.Now },
               new { Id = 8, RoleId = 1, PermissionId = 8, CreateDate = DateTime.Now },
               new { Id= 9, RoleId = 1, PermissionId = 9, CreateDate = DateTime.Now },
               new { Id = 10, RoleId = 1, PermissionId = 10, CreateDate = DateTime.Now },
               new { Id = 11, RoleId = 1, PermissionId = 11, CreateDate = DateTime.Now },
               new { Id = 12, RoleId = 1, PermissionId = 12, CreateDate = DateTime.Now },
               new { Id = 13, RoleId = 1, PermissionId = 13, CreateDate = DateTime.Now },
               new { Id = 14, RoleId = 1, PermissionId = 14, CreateDate = DateTime.Now },
               new { Id = 15, RoleId = 1, PermissionId = 15, CreateDate = DateTime.Now },
               new { Id = 16, RoleId = 1, PermissionId = 16, CreateDate = DateTime.Now },
               new { Id = 17, RoleId = 1, PermissionId = 17, CreateDate = DateTime.Now },
               new { Id = 18, RoleId = 1, PermissionId = 18, CreateDate = DateTime.Now },
               new { Id = 19, RoleId = 1, PermissionId = 19, CreateDate = DateTime.Now },
               new { Id = 20, RoleId = 1, PermissionId = 20, CreateDate = DateTime.Now },
               new { Id = 21, RoleId = 1, PermissionId = 21, CreateDate = DateTime.Now },
               new { Id = 22, RoleId = 1, PermissionId = 22, CreateDate = DateTime.Now },
               new { Id = 23, RoleId = 1, PermissionId = 23, CreateDate = DateTime.Now },
               new { Id = 24, RoleId = 1, PermissionId = 24, CreateDate = DateTime.Now },
               new { Id = 25, RoleId = 1, PermissionId = 25, CreateDate = DateTime.Now },
               new { Id = 26, RoleId = 1, PermissionId = 26, CreateDate = DateTime.Now },
               new { Id = 27, RoleId = 1, PermissionId = 27, CreateDate = DateTime.Now },
               new { Id = 28, RoleId = 1, PermissionId = 28, CreateDate = DateTime.Now },
               new { Id = 29, RoleId = 1, PermissionId = 29, CreateDate = DateTime.Now },
               new { Id = 30, RoleId = 1, PermissionId = 30, CreateDate = DateTime.Now },
               new { Id = 31, RoleId = 1, PermissionId = 31, CreateDate = DateTime.Now },
               new { Id = 32, RoleId = 1, PermissionId = 32, CreateDate = DateTime.Now },
               new { Id = 33, RoleId = 1, PermissionId = 33, CreateDate = DateTime.Now },
               new { Id = 34, RoleId = 1, PermissionId = 34, CreateDate = DateTime.Now },
               new { Id = 35, RoleId = 1, PermissionId = 35, CreateDate = DateTime.Now },
               new { Id = 36, RoleId = 1, PermissionId = 36, CreateDate = DateTime.Now },
               new { Id = 37, RoleId = 1, PermissionId = 37, CreateDate = DateTime.Now },
               new { Id = 38, RoleId = 1, PermissionId = 38, CreateDate = DateTime.Now },
               new { Id = 39, RoleId = 1, PermissionId = 39, CreateDate = DateTime.Now },
               new { Id = 40, RoleId = 1, PermissionId = 40, CreateDate = DateTime.Now },
               new { Id = 41, RoleId = 1, PermissionId = 41, CreateDate = DateTime.Now },
               new { Id = 42, RoleId = 1, PermissionId = 42, CreateDate = DateTime.Now },
               new { Id = 43, RoleId = 1, PermissionId = 43, CreateDate = DateTime.Now },
               new { Id = 44, RoleId = 1, PermissionId = 44, CreateDate = DateTime.Now });
            #endregion

            #region Permissions
            modelBuilder.Entity<Permission>()
               .HasData(new { Id = 1, PermissionTitle = "صفحه ی اصلی ", CreateDate = DateTime.Now },
                        new { Id = 2, PermissionTitle = "خروج", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 3, PermissionTitle = "تغییر پسورد", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 4, PermissionTitle = "ایجاد کاربر", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 5, PermissionTitle = "ویرایش کاربر", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 6, PermissionTitle = "گروه مهارت", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 7, PermissionTitle = "ایجاد گروه مهارت", ParentId = 6, CreateDate = DateTime.Now },
                        new { Id = 8, PermissionTitle = "ویرایش گروه مهارت", ParentId = 6, CreateDate = DateTime.Now },
                        new { Id = 9, PermissionTitle = "مهارت", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 10, PermissionTitle = " ایجاد مهارت", ParentId = 9, CreateDate = DateTime.Now },
                        new { Id = 11, PermissionTitle = "ویرایش مهارت", ParentId = 9, CreateDate = DateTime.Now },
                        new { Id = 12, PermissionTitle = "حذف مهارت", ParentId = 9, CreateDate = DateTime.Now },
                        new { Id = 13, PermissionTitle = "تحصیلات", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 14, PermissionTitle = "ایجاد تحصیلات", ParentId = 13, CreateDate = DateTime.Now },
                        new { Id = 15, PermissionTitle = "ویرایش تحصیلات", ParentId = 13, CreateDate = DateTime.Now },
                        new { Id = 16, PermissionTitle = "حذف تحصیلات", ParentId = 13, CreateDate = DateTime.Now },
                        new { Id = 17, PermissionTitle = "تجربیات", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 18, PermissionTitle = "ایجاد تجربه", ParentId = 17, CreateDate = DateTime.Now },
                        new { Id = 19, PermissionTitle = "ویرایش تجربه", ParentId = 17, CreateDate = DateTime.Now },
                        new { Id = 20, PermissionTitle = "حذف تجربه", ParentId = 17, CreateDate = DateTime.Now },
                        new { Id = 21, PermissionTitle = "مدارک", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 22, PermissionTitle = "ایجاد مدرک", ParentId = 21, CreateDate = DateTime.Now },
                        new { Id = 23, PermissionTitle = "ویرایش مدرک", ParentId = 21, CreateDate = DateTime.Now },
                        new { Id = 24, PermissionTitle = "حذف مدرک", ParentId = 21, CreateDate = DateTime.Now },
                        new { Id = 25, PermissionTitle = "گروه نمونه کارها ", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 26, PermissionTitle = "ایجاد گروه نمونه کار", ParentId = 25, CreateDate = DateTime.Now },
                        new { Id = 27, PermissionTitle = "ویرایش گروه نمونه کار", ParentId = 25, CreateDate = DateTime.Now },
                        new { Id = 28, PermissionTitle = "حذف گروه نمونه کار", ParentId = 25, CreateDate = DateTime.Now },
                        new { Id = 29, PermissionTitle = "نمونه کار", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 30, PermissionTitle = "ایجاد نمونه کار", ParentId = 29, CreateDate = DateTime.Now },
                        new { Id = 31, PermissionTitle = "ویرایش نمونه کار", ParentId = 29, CreateDate = DateTime.Now },
                        new { Id = 32, PermissionTitle = "حذف نمونه کار", ParentId = 29, CreateDate = DateTime.Now },
                        new { Id = 33, PermissionTitle = "گروه بلاگ", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 34, PermissionTitle = "ایجاد گروه بلاگ", ParentId = 33, CreateDate = DateTime.Now },
                        new { Id = 35, PermissionTitle = "ویرایش گروه بلاگ", ParentId = 33, CreateDate = DateTime.Now },
                        new { Id = 36, PermissionTitle = "حذف گروه بلاگ", ParentId = 33, CreateDate = DateTime.Now },
                        new { Id = 37, PermissionTitle = "بلاگ", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 38, PermissionTitle = "ایجاد بلاگ", ParentId = 37, CreateDate = DateTime.Now },
                        new { Id = 39, PermissionTitle = "ویرایش بلاگ", ParentId = 37, CreateDate = DateTime.Now },
                        new { Id = 40, PermissionTitle = "حذف بلاگ", ParentId = 37, CreateDate = DateTime.Now },
                        new { Id = 41, PermissionTitle = "نظرات بلاگ", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 42, PermissionTitle = "پیام های من", ParentId = 1, CreateDate = DateTime.Now },
                        new { Id = 43, PermissionTitle = "پاسخ پیام", ParentId = 42, CreateDate = DateTime.Now },
                        new { Id = 44, PermissionTitle = "حذف پیام", ParentId = 42, CreateDate = DateTime.Now });
            #endregion
  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }


}
