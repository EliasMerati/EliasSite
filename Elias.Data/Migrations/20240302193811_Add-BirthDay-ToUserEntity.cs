using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBirthDayToUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthDay",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreateDate", "MainDescription" },
                values: new object[] { "1362/06/30", new DateTime(2024, 3, 2, 23, 8, 8, 570, DateTimeKind.Local).AddTicks(7238), "با بیش از 5 سال تجربه در کدنویسی و توسعه ی برنامه های .NET  من یک برنامه نویس هوشمند و خلاق هستم.من مسلط به زبان برنامه نویسی C#  مانند ASP .NET,ASP.NET CORE, ASP.NET RAZORPAGES آشنایی کامل دارم.من متعهد به اهداف شرکت و ارا یه ی راه حل های برتر هستم.هستم و  توانایی توسعه ی برنامه های تحت وب و دسکتاپ را دارم. من در ایجاد برنامه های کاربردی و کیفیت بالا تخصص دارم و توانایی مشارکت در تیم را به خوبی میدانم. همچنین من با استفاده از فریمورک های مختلفی " });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MainDescription" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 16, 22, 773, DateTimeKind.Local).AddTicks(5926), "" });
        }
    }
}
