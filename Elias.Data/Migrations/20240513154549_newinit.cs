using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class newinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2252), 1, "کاربران" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2254), 2, "خروج" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2256), 2, "تغییر پسورد" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2258), 2, "ایجاد کاربر" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2259), 2, "ویرایش کاربر" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2261), 1, "گروه مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2263), 7, "ایجاد گروه مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2264), 7, "ویرایش گروه مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2266), 1, "مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2268), 10, " ایجاد مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2270), 10, "ویرایش مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2272), 10, "حذف مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2274), 1, "تحصیلات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2275), 14, "ایجاد تحصیلات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2277), 14, "ویرایش تحصیلات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2279), 14, "حذف تحصیلات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2281), 1, "تجربیات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2283), 18, "ایجاد تجربه" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2284), 18, "ویرایش تجربه" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2286), 18, "حذف تجربه" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2287), 1, "مدارک" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2289), 22, "ایجاد مدرک" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2291), 22, "ویرایش مدرک" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2292), 22, "حذف مدرک" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2294), 1, "گروه نمونه کارها " });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2295), 26, "ایجاد گروه نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2297), 26, "ویرایش گروه نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2299), 26, "حذف گروه نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2300), 1, "نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2302), 30, "ایجاد نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2304), 30, "ویرایش نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2305), 30, "حذف نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2307), 1, "گروه بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2308), 34, "ایجاد گروه بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2310), 34, "ویرایش گروه بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2312), 34, "حذف گروه بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2313), 1, "بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2315), 38, "ایجاد بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2317), 38, "ویرایش بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2318), 38, "حذف بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 13, 20, 15, 46, 35, DateTimeKind.Local).AddTicks(2026));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9131), 41, "خروج" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9135), 41, "تغییر پسورد" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9137), 41, "ایجاد کاربر" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9139), 41, "ویرایش کاربر" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9141), 1, "گروه مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9143), 6, "ایجاد گروه مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9145), 6, "ویرایش گروه مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9146), 1, "مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9149), 9, " ایجاد مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9151), 9, "ویرایش مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9153), 9, "حذف مهارت" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9155), 1, "تحصیلات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9157), 13, "ایجاد تحصیلات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9159), 13, "ویرایش تحصیلات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9161), 13, "حذف تحصیلات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9163), 1, "تجربیات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9165), 17, "ایجاد تجربه" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9166), 17, "ویرایش تجربه" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9168), 17, "حذف تجربه" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9170), 1, "مدارک" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9172), 21, "ایجاد مدرک" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9174), 21, "ویرایش مدرک" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9176), 21, "حذف مدرک" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9178), 1, "گروه نمونه کارها " });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9180), 25, "ایجاد گروه نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9182), 25, "ویرایش گروه نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9183), 25, "حذف گروه نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9185), 1, "نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9187), 29, "ایجاد نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9189), 29, "ویرایش نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9191), 29, "حذف نمونه کار" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9193), 1, "گروه بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9195), 33, "ایجاد گروه بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9197), 33, "ویرایش گروه بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9199), 33, "حذف گروه بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9201), 1, "بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9203), 37, "ایجاد بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9205), 37, "ویرایش بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9208), 37, "حذف بلاگ" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateDate", "ParentId", "PermissionTitle" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 10, 44, 526, DateTimeKind.Local).AddTicks(9274), 1, "کاربران" });

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
    }
}
