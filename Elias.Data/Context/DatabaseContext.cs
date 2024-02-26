using Elias.Common;
using Elias.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Elias.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        private void SeedData(ModelBuilder modelBuilder)
        {
            #region Admin
            modelBuilder.Entity<User>()
               .HasData(new
               {
                   Id = 1,
                   UserName = "EliasAdmin",
                   CreateDate = DateTime.Now.ToString(),
                   Name = "الیاس",
                   Family = "مرآتی",
                   Email = "elias.merati@gmail.com",
                   Password = "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70",
                   Ostan = "خراسان رضوی",
                   UserImage="Null",
                   City ="نیشابور",
                   Address="خیابان امیر کبیر - امیر کبیر 9/5 - پلاک 141",
                   ShortDescription="برنامه نویس دات نت با بیش از 5 سال سابقه ی برنامه نویسی وب و دسکتاپ",
                   MainDescription="",
                   Resumeh="Null",
                   MainSkill= ".Net Developer",
                   Skill= "C# , Asp .Net MVC , Asp .Net RazorPages , Asp .Net CoreMVC , Blazor",
                   GitHub= "EliasMerati",
                   LinkedIn= "elias-merati",
                   PhoneNumber="09223610626",
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
