using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class initToServer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "GitHub", "LinkedIn" },
                values: new object[] { new DateTime(2024, 4, 23, 22, 29, 42, 204, DateTimeKind.Local).AddTicks(3281), "https://github.com/EliasMerati", "https://www.linkedin.com/in/elias-merati" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "GitHub", "LinkedIn" },
                values: new object[] { new DateTime(2024, 4, 8, 0, 53, 52, 238, DateTimeKind.Local).AddTicks(9471), "EliasMerati", "elias-merati" });
        }
    }
}
