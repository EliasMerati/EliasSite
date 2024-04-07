using Elias.Data.Entities;
using Elias.Data.Entities.Blog;
using Elias.Data.Entities.Certificate;
using Elias.Data.Entities.Comment;
using Elias.Data.Entities.Education;
using Elias.Data.Entities.Experience;
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


        private void SeedData(ModelBuilder modelBuilder)
        {
            #region Admin
            modelBuilder.Entity<User>()
               .HasData(new
               {
                   Id = 1,
                   UserName = "EliasAdmin",
                   CreateDate = DateTime.Now,
                   Name = "الیاس",
                   Family = "مرآتی",
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
                   Skill = "C# , Asp .Net MVC , Asp .Net RazorPages , Asp .Net CoreMVC , Blazor",
                   GitHub = "EliasMerati",
                   LinkedIn = "elias-merati",
                   PhoneNumber = "09223610626",
                   Skype = "Elias Merati",
                   IsActive = true,
               });
            #endregion
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }


}
