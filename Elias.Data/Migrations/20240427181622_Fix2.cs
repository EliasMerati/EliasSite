using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Skills" },
                values: new object[] { new DateTime(2024, 4, 27, 22, 46, 21, 412, DateTimeKind.Local).AddTicks(5620), "C# , Asp .Net MVC , Asp .Net RazorPages , Asp .Net CoreMVC , Blazor" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Skills" },
                values: new object[] { new DateTime(2024, 4, 27, 22, 34, 44, 829, DateTimeKind.Local).AddTicks(7949), null });
        }
    }
}
