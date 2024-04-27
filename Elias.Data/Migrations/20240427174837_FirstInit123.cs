using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstInit123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 27, 22, 18, 35, 983, DateTimeKind.Local).AddTicks(350));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 25, 0, 28, 42, 682, DateTimeKind.Local).AddTicks(6126));
        }
    }
}
