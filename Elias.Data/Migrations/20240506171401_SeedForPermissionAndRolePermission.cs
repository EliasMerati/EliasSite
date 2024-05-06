using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedForPermissionAndRolePermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { 1, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6691), null, "صفحه ی اصلی " });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6694), 1, "خروج" },
                    { 3, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6697), 1, "تغییر پسورد" },
                    { 4, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6699), 1, "ایجاد کاربر" },
                    { 5, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6700), 1, "ویرایش کاربر" },
                    { 6, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6703), 1, "گروه مهارت" },
                    { 9, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6708), 1, "مهارت" },
                    { 13, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6715), 1, "تحصیلات" },
                    { 17, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6721), 1, "تجربیات" },
                    { 21, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6728), 1, "مدارک" },
                    { 25, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6735), 1, "گروه نمونه کارها " },
                    { 29, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6742), 1, "نمونه کار" },
                    { 33, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6749), 1, "گروه بلاگ" },
                    { 37, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6756), 1, "بلاگ" },
                    { 41, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6763), 1, "نظرات بلاگ" },
                    { 42, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6764), 1, "پیام های من" }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreateDate", "PermissionId", "RoleId" },
                values: new object[] { 1, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6470), 1, 1 });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6705), 6, "ایجاد گروه مهارت" },
                    { 8, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6706), 6, "ویرایش گروه مهارت" },
                    { 10, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6710), 9, " ایجاد مهارت" },
                    { 11, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6711), 9, "ویرایش مهارت" },
                    { 12, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6713), 9, "حذف مهارت" },
                    { 14, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6716), 13, "ایجاد تحصیلات" },
                    { 15, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6718), 13, "ویرایش تحصیلات" },
                    { 16, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6720), 13, "حذف تحصیلات" },
                    { 18, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6723), 17, "ایجاد تجربه" },
                    { 19, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6725), 17, "ویرایش تجربه" },
                    { 20, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6727), 17, "حذف تجربه" },
                    { 22, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6730), 21, "ایجاد مدرک" },
                    { 23, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6732), 21, "ویرایش مدرک" },
                    { 24, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6733), 21, "حذف مدرک" },
                    { 26, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6737), 25, "ایجاد گروه نمونه کار" },
                    { 27, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6739), 25, "ویرایش گروه نمونه کار" },
                    { 28, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6740), 25, "حذف گروه نمونه کار" },
                    { 30, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6744), 29, "ایجاد نمونه کار" },
                    { 31, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6746), 29, "ویرایش نمونه کار" },
                    { 32, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6747), 29, "حذف نمونه کار" },
                    { 34, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6751), 33, "ایجاد گروه بلاگ" },
                    { 35, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6752), 33, "ویرایش گروه بلاگ" },
                    { 36, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6754), 33, "حذف گروه بلاگ" },
                    { 38, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6758), 37, "ایجاد بلاگ" },
                    { 39, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6759), 37, "ویرایش بلاگ" },
                    { 40, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6761), 37, "حذف بلاگ" },
                    { 43, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6766), 42, "پاسخ پیام" },
                    { 44, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6768), 42, "حذف پیام" }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreateDate", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6472), 2, 1 },
                    { 3, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6474), 3, 1 },
                    { 4, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6476), 4, 1 },
                    { 5, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6478), 5, 1 },
                    { 6, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6479), 6, 1 },
                    { 9, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6485), 9, 1 },
                    { 13, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6491), 13, 1 },
                    { 17, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6498), 17, 1 },
                    { 21, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6505), 21, 1 },
                    { 25, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6512), 25, 1 },
                    { 29, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6519), 29, 1 },
                    { 33, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6526), 33, 1 },
                    { 37, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6532), 37, 1 },
                    { 41, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6539), 41, 1 },
                    { 42, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6541), 42, 1 },
                    { 7, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6481), 7, 1 },
                    { 8, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6483), 8, 1 },
                    { 10, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6486), 10, 1 },
                    { 11, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6488), 11, 1 },
                    { 12, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6490), 12, 1 },
                    { 14, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6493), 14, 1 },
                    { 15, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6495), 15, 1 },
                    { 16, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6497), 16, 1 },
                    { 18, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6500), 18, 1 },
                    { 19, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6502), 19, 1 },
                    { 20, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6503), 20, 1 },
                    { 22, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6507), 22, 1 },
                    { 23, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6509), 23, 1 },
                    { 24, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6511), 24, 1 },
                    { 26, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6514), 26, 1 },
                    { 27, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6516), 27, 1 },
                    { 28, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6517), 28, 1 },
                    { 30, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6521), 30, 1 },
                    { 31, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6523), 31, 1 },
                    { 32, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6524), 32, 1 },
                    { 34, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6528), 34, 1 },
                    { 35, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6529), 35, 1 },
                    { 36, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6531), 36, 1 },
                    { 38, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6534), 38, 1 },
                    { 39, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6536), 39, 1 },
                    { 40, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6538), 40, 1 },
                    { 43, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6543), 43, 1 },
                    { 44, new DateTime(2024, 5, 6, 21, 43, 58, 866, DateTimeKind.Local).AddTicks(6616), 44, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 5, 17, 3, 10, 127, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 5, 17, 3, 10, 127, DateTimeKind.Local).AddTicks(7384));
        }
    }
}
