using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class BugFixForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ParentId" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9131), 41 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ParentId" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9135), 41 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ParentId" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9137), 41 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ParentId" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9139), 41 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateDate", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9274), "کاربران" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(8908));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ParentId" },
                values: new object[] { new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9504), 1 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ParentId" },
                values: new object[] { new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9509), 1 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ParentId" },
                values: new object[] { new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9512), 1 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ParentId" },
                values: new object[] { new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9517), 1 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateDate", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9586), "نظرات بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 8, 20, 50, 57, 361, DateTimeKind.Local).AddTicks(8267));
        }
    }
}
