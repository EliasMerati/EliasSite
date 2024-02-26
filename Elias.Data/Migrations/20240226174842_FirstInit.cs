using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Familly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ostan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resumeh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainSkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GitHub = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "City", "CreateDate", "Email", "Familly", "GitHub", "IsActive", "LinkedIn", "MainDescription", "MainSkill", "Name", "Ostan", "Password", "PhoneNumber", "Resumeh", "ShortDescription", "Skills", "Skype", "UserImage", "UserName" },
                values: new object[] { 1, "خیابان امیر کبیر - امیر کبیر 9/5 - پلاک 141", "نیشابور", "2/26/2024 9:18:40 PM", "elias.merati@gmail.com", null, "EliasMerati", true, "elias-merati", "", ".Net Developer", "الیاس", "خراسان رضوی", "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70", "09223610626", "Null", "برنامه نویس دات نت با بیش از 5 سال سابقه ی برنامه نویسی وب و دسکتاپ", null, "Elias Merati", "Null", "EliasAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
