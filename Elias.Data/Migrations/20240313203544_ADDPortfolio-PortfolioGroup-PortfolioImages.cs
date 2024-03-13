using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class ADDPortfolioPortfolioGroupPortfolioImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PortfolioGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    PortfolioName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfolioFamily = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfolioDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainPicure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfolioLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortfolioGroupId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portfolios_PortfolioGroups_PortfolioGroupId",
                        column: x => x.PortfolioGroupId,
                        principalTable: "PortfolioGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortfolioImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioId = table.Column<int>(type: "int", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PortfolioImages_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 14, 0, 5, 41, 163, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioImages_PortfolioId",
                table: "PortfolioImages",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_PortfolioGroupId",
                table: "Portfolios",
                column: "PortfolioGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioImages");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "PortfolioGroups");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 12, 20, 13, 27, 841, DateTimeKind.Local).AddTicks(7912));
        }
    }
}
