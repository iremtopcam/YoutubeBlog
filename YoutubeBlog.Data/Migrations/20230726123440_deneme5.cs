using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class deneme5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("b0ae848e-84a4-41fe-a75c-eedfbca479a9"));

            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("bb10a047-8c09-4a7c-9089-feae99334114"));

            //migrationBuilder.DeleteData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"));

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("22cd830c-16c4-4ac1-9d1f-8e0b0686ad68"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 26, 15, 34, 40, 10, DateTimeKind.Local).AddTicks(7214));

            //migrationBuilder.InsertData(
            //    table: "Categories",
            //    columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
            //    values: new object[] { new Guid("194542ec-73c1-4e46-955d-a691ee6b5c21"), "Admin Test", new DateTime(2023, 7, 26, 15, 34, 40, 10, DateTimeKind.Local).AddTicks(7209), null, null, false, null, null, "ASP.net Core" });

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("9c41643f-a6af-4621-8110-82bc6254aad8"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 26, 15, 34, 40, 10, DateTimeKind.Local).AddTicks(7316));

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 26, 15, 34, 40, 10, DateTimeKind.Local).AddTicks(7310));

            //migrationBuilder.InsertData(
            //    table: "Articles",
            //    columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
            //    values: new object[,]
            //    {
            //        { new Guid("88e58633-6cf5-491d-b0fb-150c08586cc2"), new Guid("194542ec-73c1-4e46-955d-a691ee6b5c21"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 26, 15, 34, 40, 10, DateTimeKind.Local).AddTicks(7032), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
            //        { new Guid("c476013c-88ba-4dad-8a90-53433f0a1331"), new Guid("194542ec-73c1-4e46-955d-a691ee6b5c21"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 26, 15, 34, 40, 10, DateTimeKind.Local).AddTicks(7037), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", 15 }
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("88e58633-6cf5-491d-b0fb-150c08586cc2"));

            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("c476013c-88ba-4dad-8a90-53433f0a1331"));

            //migrationBuilder.DeleteData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("194542ec-73c1-4e46-955d-a691ee6b5c21"));

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("22cd830c-16c4-4ac1-9d1f-8e0b0686ad68"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 26, 15, 29, 35, 131, DateTimeKind.Local).AddTicks(9170));

            //migrationBuilder.InsertData(
            //    table: "Categories",
            //    columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
            //    values: new object[] { new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Admin Test", new DateTime(2023, 7, 26, 15, 29, 35, 131, DateTimeKind.Local).AddTicks(9166), null, null, false, null, null, "ASP.net Core" });

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("9c41643f-a6af-4621-8110-82bc6254aad8"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 26, 15, 29, 35, 131, DateTimeKind.Local).AddTicks(9236));

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 26, 15, 29, 35, 131, DateTimeKind.Local).AddTicks(9232));

            //migrationBuilder.InsertData(
            //    table: "Articles",
            //    columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
            //    values: new object[,]
            //    {
            //        { new Guid("b0ae848e-84a4-41fe-a75c-eedfbca479a9"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 26, 15, 29, 35, 131, DateTimeKind.Local).AddTicks(8997), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
            //        { new Guid("bb10a047-8c09-4a7c-9089-feae99334114"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 26, 15, 29, 35, 131, DateTimeKind.Local).AddTicks(9002), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", 15 }
            //    });
        }
    }
}
