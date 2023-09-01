using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Articleentitynameupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("7952ca01-6988-43ee-a7fe-e6c904a0a62a"));

            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("ef5651ce-2def-4430-b19e-536d93b0e18c"));

            //migrationBuilder.InsertData(
            //    table: "Articles",
            //    columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
            //    values: new object[,]
            //    {
            //        { new Guid("6483d0a1-c99a-4f42-92cc-6b24d7ebe1ef"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 8, 28, 17, 15, 25, 416, DateTimeKind.Local).AddTicks(390), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
            //        { new Guid("d6266c0d-ac55-4e6e-861a-44684aa4469d"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 8, 28, 17, 15, 25, 416, DateTimeKind.Local).AddTicks(410), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
            //    });

            //migrationBuilder.UpdateData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
            //    column: "ConcurrencyStamp",
            //    value: "66461ec7-c607-4f47-8859-873bfa090971");

            //migrationBuilder.UpdateData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
            //    column: "ConcurrencyStamp",
            //    value: "3b9edb30-1b46-4852-86ff-25afdc601a50");

            //migrationBuilder.UpdateData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
            //    column: "ConcurrencyStamp",
            //    value: "432a1a5c-2e60-408f-8cf1-6bcbd82caa98");

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "cdf0fc67-8afa-451a-a2e9-fc14231493f7", "AQAAAAEAACcQAAAAELdRubs2VtPuudXI8ThR4T46RlQX91gpTSyzOE3zm1iUaJy8/WgBCyLd8/U4vAPTwg==", "b3cb03bb-c648-4563-a609-39d21a390b91" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "32f0ae7b-7378-4abc-b34d-31ecd708d6d6", "AQAAAAEAACcQAAAAECTe8SAue1HCTizP56aktsCSzi879ZAr5toaZcZ0Mbyxqhsq9gCXQ8ym9895r7tODA==", "356997a0-fe3e-4f58-b052-c78908b8f18b" });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("22cd830c-16c4-4ac1-9d1f-8e0b0686ad68"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 8, 28, 17, 15, 25, 416, DateTimeKind.Local).AddTicks(616));

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 8, 28, 17, 15, 25, 416, DateTimeKind.Local).AddTicks(612));

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("9c41643f-a6af-4621-8110-82bc6254aad8"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 8, 28, 17, 15, 25, 416, DateTimeKind.Local).AddTicks(745));

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 8, 28, 17, 15, 25, 416, DateTimeKind.Local).AddTicks(742));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6483d0a1-c99a-4f42-92cc-6b24d7ebe1ef"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d6266c0d-ac55-4e6e-861a-44684aa4469d"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("7952ca01-6988-43ee-a7fe-e6c904a0a62a"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6171), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("ef5651ce-2def-4430-b19e-536d93b0e18c"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6160), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "9db78761-9a42-40ed-b43d-4c04b5d5273a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "a62e7e12-d8fb-4f2c-a6c2-053b2fa6d6ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "59408e6b-8a4b-4bd7-beb8-272154df04e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e7210e3-8be4-4b5f-949d-bfff9f6b1d96", "AQAAAAEAACcQAAAAEMkxhJF9oeuLeaqH7dBXUuGPk0PSQcH62pfLnQ4/Z+qVlxXyjkJqngMLR6L/F/4tRw==", "702fbc8e-4177-4442-80dd-4d215e380cb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10fc1f84-fa65-4c9e-97b5-2f11c46c9e91", "AQAAAAEAACcQAAAAEDTS3vGsXJx4aIgyT4HBWPj0R0+5mEffXT26Blx8nUiyUFQmLIt1eO4C+TnSc2UGdQ==", "cee08a50-adc5-4d27-8574-fab1f45bb05a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22cd830c-16c4-4ac1-9d1f-8e0b0686ad68"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9c41643f-a6af-4621-8110-82bc6254aad8"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6608));
        }
    }
}
