using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a3c292a2-88a9-4c99-b762-9ce33e1d7d69"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e0d6158d-c109-426d-85f4-70b520ca5135"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("6dccd4c5-deb6-4d9f-bb2c-af36bcfb94e5"), new Guid("7418fb6d-17c3-486e-93f6-0623c7b98730"), "Ypay zeka dunyayı yok edior", "betus", new DateTime(2023, 9, 1, 12, 3, 2, 602, DateTimeKind.Local).AddTicks(4891), null, null, new Guid("f2cf9caf-cd2c-48ca-bc56-4e2a801b9ce9"), false, null, null, "deneme makalesiii", 15 },
                    { new Guid("937f5cbf-7dec-4c3d-8965-79cc379a44d3"), new Guid("17ea0da3-f0af-40fd-aeb9-62436552b0c6"), "Ypay zeka dunyayı yok etmiot", "betus2", new DateTime(2023, 9, 1, 12, 3, 2, 602, DateTimeKind.Local).AddTicks(4897), null, null, new Guid("a74d2084-384c-4722-9841-ffdc36c0a632"), false, null, null, "deneme makalesiii 2", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("17ea0da3-f0af-40fd-aeb9-62436552b0c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 12, 3, 2, 602, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7418fb6d-17c3-486e-93f6-0623c7b98730"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 12, 3, 2, 602, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a74d2084-384c-4722-9841-ffdc36c0a632"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 12, 3, 2, 602, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f2cf9caf-cd2c-48ca-bc56-4e2a801b9ce9"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 12, 3, 2, 602, DateTimeKind.Local).AddTicks(5171));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6dccd4c5-deb6-4d9f-bb2c-af36bcfb94e5"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("937f5cbf-7dec-4c3d-8965-79cc379a44d3"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("a3c292a2-88a9-4c99-b762-9ce33e1d7d69"), new Guid("7418fb6d-17c3-486e-93f6-0623c7b98730"), "Ypay zeka dunyayı yok edior", "betus", new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(687), null, null, new Guid("f2cf9caf-cd2c-48ca-bc56-4e2a801b9ce9"), false, null, null, "deneme makalesiii", 15 },
                    { new Guid("e0d6158d-c109-426d-85f4-70b520ca5135"), new Guid("17ea0da3-f0af-40fd-aeb9-62436552b0c6"), "Ypay zeka dunyayı yok etmiot", "betus2", new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(693), null, null, new Guid("a74d2084-384c-4722-9841-ffdc36c0a632"), false, null, null, "deneme makalesiii 2", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("17ea0da3-f0af-40fd-aeb9-62436552b0c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7418fb6d-17c3-486e-93f6-0623c7b98730"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a74d2084-384c-4722-9841-ffdc36c0a632"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f2cf9caf-cd2c-48ca-bc56-4e2a801b9ce9"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 16, 42, 53, 564, DateTimeKind.Local).AddTicks(961));
        }
    }
}
