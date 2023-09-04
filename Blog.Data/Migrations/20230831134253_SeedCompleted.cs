using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("17ea0da3-f0af-40fd-aeb9-62436552b0c6"), "betus test2", new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(860), null, null, false, null, null, "asp.net ile test2" },
                    { new Guid("7418fb6d-17c3-486e-93f6-0623c7b98730"), "betus test", new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(858), null, null, false, null, null, "asp.net ile test" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("a74d2084-384c-4722-9841-ffdc36c0a632"), "betus test2", new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(966), null, null, "images//testimagei", "png", false, null, null },
                    { new Guid("f2cf9caf-cd2c-48ca-bc56-4e2a801b9ce9"), "betus test", new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(961), null, null, "images//testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("a3c292a2-88a9-4c99-b762-9ce33e1d7d69"), new Guid("7418fb6d-17c3-486e-93f6-0623c7b98730"), "Ypay zeka dunyayı yok edior", "betus", new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(687), null, null, new Guid("f2cf9caf-cd2c-48ca-bc56-4e2a801b9ce9"), false, null, null, "deneme makalesiii", 15 },
                    { new Guid("e0d6158d-c109-426d-85f4-70b520ca5135"), new Guid("17ea0da3-f0af-40fd-aeb9-62436552b0c6"), "Ypay zeka dunyayı yok etmiot", "betus2", new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(693), null, null, new Guid("a74d2084-384c-4722-9841-ffdc36c0a632"), false, null, null, "deneme makalesiii 2", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a3c292a2-88a9-4c99-b762-9ce33e1d7d69"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e0d6158d-c109-426d-85f4-70b520ca5135"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("17ea0da3-f0af-40fd-aeb9-62436552b0c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7418fb6d-17c3-486e-93f6-0623c7b98730"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a74d2084-384c-4722-9841-ffdc36c0a632"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f2cf9caf-cd2c-48ca-bc56-4e2a801b9ce9"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
