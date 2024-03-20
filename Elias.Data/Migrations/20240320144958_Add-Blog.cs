using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elias.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_Blogs_CommentId",
                table: "BlogComments");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "BlogComments",
                newName: "BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComments_CommentId",
                table: "BlogComments",
                newName: "IX_BlogComments_BlogId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 20, 18, 19, 56, 514, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_Blogs_BlogId",
                table: "BlogComments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_Blogs_BlogId",
                table: "BlogComments");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "BlogComments",
                newName: "CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComments_BlogId",
                table: "BlogComments",
                newName: "IX_BlogComments_CommentId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 18, 22, 47, 22, 48, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_Blogs_CommentId",
                table: "BlogComments",
                column: "CommentId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
