using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class foreignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("33dfd4ea-c782-498e-9ab7-1da936fc53db"));

            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("88556ffb-7fd2-4bb7-b8ae-ce5b65349aab"));

            //migrationBuilder.InsertData(
            //    table: "Articles",
            //    columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
            //    values: new object[,]
            //    {
            //        { new Guid("7952ca01-6988-43ee-a7fe-e6c904a0a62a"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6171), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
            //        { new Guid("ef5651ce-2def-4430-b19e-536d93b0e18c"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6160), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
            //    });

            //migrationBuilder.UpdateData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
            //    column: "ConcurrencyStamp",
            //    value: "9db78761-9a42-40ed-b43d-4c04b5d5273a");

            //migrationBuilder.UpdateData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
            //    column: "ConcurrencyStamp",
            //    value: "a62e7e12-d8fb-4f2c-a6c2-053b2fa6d6ff");

            //migrationBuilder.UpdateData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
            //    column: "ConcurrencyStamp",
            //    value: "59408e6b-8a4b-4bd7-beb8-272154df04e5");

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "8e7210e3-8be4-4b5f-949d-bfff9f6b1d96", "AQAAAAEAACcQAAAAEMkxhJF9oeuLeaqH7dBXUuGPk0PSQcH62pfLnQ4/Z+qVlxXyjkJqngMLR6L/F/4tRw==", "702fbc8e-4177-4442-80dd-4d215e380cb3" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "10fc1f84-fa65-4c9e-97b5-2f11c46c9e91", "AQAAAAEAACcQAAAAEDTS3vGsXJx4aIgyT4HBWPj0R0+5mEffXT26Blx8nUiyUFQmLIt1eO4C+TnSc2UGdQ==", "cee08a50-adc5-4d27-8574-fab1f45bb05a" });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("22cd830c-16c4-4ac1-9d1f-8e0b0686ad68"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6463));

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6460));

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("9c41643f-a6af-4621-8110-82bc6254aad8"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6615));

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 17, 58, 45, 684, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.AddForeignKey(
               name: "FK_Articles_AspNetUsers_UserId",
               table: "Articles",
               column: "UserId",
               principalTable: "AspNetUsers",
               principalColumn: "Id",
               onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7952ca01-6988-43ee-a7fe-e6c904a0a62a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ef5651ce-2def-4430-b19e-536d93b0e18c"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("33dfd4ea-c782-498e-9ab7-1da936fc53db"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9347), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("88556ffb-7fd2-4bb7-b8ae-ce5b65349aab"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9353), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "2d395401-4c9d-4033-aeaf-852b1526a044");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "155f05b4-fc10-4629-9d62-626d681e5d71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "1c827470-12af-4876-bf9f-68b843ff5a29");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b640f21f-04d9-4513-90f1-7b2d8eca4ca6", "AQAAAAEAACcQAAAAEFgOy1w2+7dVEo8f7/1FZGUOo6dQ+MT7XBOb/vikL6DCrkYcM5413xv+cqqPIsO6jQ==", "9d59cb20-303d-49fb-9c19-edb1b0b60193" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a711f960-e1c0-4dc1-ab93-b0dd80bfc2b3", "AQAAAAEAACcQAAAAEPiprIsfnnzlFsq2HcVIMncddtyDqpqBNm3GhA/txemmDXOcCyAuLOedulR59synWQ==", "74ada1a7-9455-45e2-9bf9-c1ffc6c44167" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22cd830c-16c4-4ac1-9d1f-8e0b0686ad68"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9c41643f-a6af-4621-8110-82bc6254aad8"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9607));
        }
    }
}
