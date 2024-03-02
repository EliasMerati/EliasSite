using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBirthDayToUserEntity1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MainDescription", "Resumeh" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 42, 19, 197, DateTimeKind.Local).AddTicks(8873), "با بیش از 5 سال تجربه در کدنویسی و توسعه ی برنامه های NET. من یک برنامه نویس هوشمند و خلاق هستم.من مسلط به زبان برنامه نویسی #C هستم و توانایی توسعه ی برنامه های تحت وب و دسکتاپ را دارم. من در ایجاد برنامه های کاربردی و کیفیت بالا تخصص دارم و توانایی مشارکت در تیم را به خوبی میدانم. همچنین من با استفاده از فریمورک های مختلفی مانند  ASP .NET MVC,ASP .NET,ASP.NET CORE, ASP.NET RAZORPAGES آشنایی کامل دارم.من متعهد به اهداف شرکت و ارا یه ی راه حل های برتر هستم.", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MainDescription", "Resumeh" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 8, 8, 570, DateTimeKind.Local).AddTicks(7238), "با بیش از 5 سال تجربه در کدنویسی و توسعه ی برنامه های .NET  من یک برنامه نویس هوشمند و خلاق هستم.من مسلط به زبان برنامه نویسی C#  مانند ASP .NET,ASP.NET CORE, ASP.NET RAZORPAGES آشنایی کامل دارم.من متعهد به اهداف شرکت و ارا یه ی راه حل های برتر هستم.هستم و  توانایی توسعه ی برنامه های تحت وب و دسکتاپ را دارم. من در ایجاد برنامه های کاربردی و کیفیت بالا تخصص دارم و توانایی مشارکت در تیم را به خوبی میدانم. همچنین من با استفاده از فریمورک های مختلفی ", "Null" });
        }
    }
}
