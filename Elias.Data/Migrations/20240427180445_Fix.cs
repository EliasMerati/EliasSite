using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Familly" },
                values: new object[] { new DateTime(2024, 4, 27, 22, 34, 44, 829, DateTimeKind.Local).AddTicks(7949), "مرآتی" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Familly" },
                values: new object[] { new DateTime(2024, 4, 27, 22, 18, 35, 983, DateTimeKind.Local).AddTicks(350), null });
        }
    }
}
