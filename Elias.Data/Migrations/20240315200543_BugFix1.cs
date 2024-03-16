using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class BugFix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_PortfolioGroups_PortfolioGroupId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_PortfolioGroupId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioGroupId",
                table: "Portfolios");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 15, 23, 35, 40, 408, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_GroupId",
                table: "Portfolios",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_PortfolioGroups_GroupId",
                table: "Portfolios",
                column: "GroupId",
                principalTable: "PortfolioGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_PortfolioGroups_GroupId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_GroupId",
                table: "Portfolios");

            migrationBuilder.AddColumn<int>(
                name: "PortfolioGroupId",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 15, 22, 43, 15, 134, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_PortfolioGroupId",
                table: "Portfolios",
                column: "PortfolioGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_PortfolioGroups_PortfolioGroupId",
                table: "Portfolios",
                column: "PortfolioGroupId",
                principalTable: "PortfolioGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
