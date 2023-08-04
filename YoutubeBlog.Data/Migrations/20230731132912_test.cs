using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("a457d502-b0f9-490f-bcf0-02286a72af2c"));

            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("d5744c63-0e69-46fe-9432-53fd1de06438"));

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            //migrationBuilder.InsertData(
            //    table: "Articles",
            //    columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
            //    values: new object[,]
            //    {
            //        { new Guid("33dfd4ea-c782-498e-9ab7-1da936fc53db"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9347), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
            //        { new Guid("88556ffb-7fd2-4bb7-b8ae-ce5b65349aab"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9353), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
            //    });

            //migrationBuilder.UpdateData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
            //    column: "ConcurrencyStamp",
            //    value: "2d395401-4c9d-4033-aeaf-852b1526a044");

            //migrationBuilder.UpdateData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
            //    column: "ConcurrencyStamp",
            //    value: "155f05b4-fc10-4629-9d62-626d681e5d71");

            //migrationBuilder.UpdateData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
            //    column: "ConcurrencyStamp",
            //    value: "1c827470-12af-4876-bf9f-68b843ff5a29");

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
            //    columns: new[] { "ConcurrencyStamp", "ImageId", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "b640f21f-04d9-4513-90f1-7b2d8eca4ca6", new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), "AQAAAAEAACcQAAAAEFgOy1w2+7dVEo8f7/1FZGUOo6dQ+MT7XBOb/vikL6DCrkYcM5413xv+cqqPIsO6jQ==", "9d59cb20-303d-49fb-9c19-edb1b0b60193" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
            //    columns: new[] { "ConcurrencyStamp", "ImageId", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "a711f960-e1c0-4dc1-ab93-b0dd80bfc2b3", new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), "AQAAAAEAACcQAAAAEPiprIsfnnzlFsq2HcVIMncddtyDqpqBNm3GhA/txemmDXOcCyAuLOedulR59synWQ==", "74ada1a7-9455-45e2-9bf9-c1ffc6c44167" });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("22cd830c-16c4-4ac1-9d1f-8e0b0686ad68"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9514));

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9511));

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("9c41643f-a6af-4621-8110-82bc6254aad8"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9623));

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 16, 29, 12, 445, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Articles_UserId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("33dfd4ea-c782-498e-9ab7-1da936fc53db"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("88556ffb-7fd2-4bb7-b8ae-ce5b65349aab"));

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Articles");

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("a457d502-b0f9-490f-bcf0-02286a72af2c"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(1964), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", 15 },
                    { new Guid("d5744c63-0e69-46fe-9432-53fd1de06438"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(1959), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "1dcdc364-57ca-4451-85c6-dc591adaa70d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "c3b219c9-a258-4b0e-b98d-446dec14acfb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "ba63475f-cb58-424e-808b-e1b57b219634");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d8cd9c9-23d0-4b58-9469-4a6bf27b4e9a", "AQAAAAEAACcQAAAAEPy1KKNspuN9dmODpfwUMzP0wH2650I0CMtFYxLxXIYhrq/mIyREURruXW4ZvkmoJQ==", "38d0ef54-88fa-4e45-85a1-aa45f2da5108" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44265f62-9bef-44d9-8694-ec7348d6da1b", "AQAAAAEAACcQAAAAEGPEBvkpAy2viZ518ZanAQozP4KYCFMrwKhg28nfRBV8WC58gDOZlnOBrHvrgriqdQ==", "ccedc756-133c-4c87-a1cc-73bf08c653a0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22cd830c-16c4-4ac1-9d1f-8e0b0686ad68"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9c41643f-a6af-4621-8110-82bc6254aad8"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
