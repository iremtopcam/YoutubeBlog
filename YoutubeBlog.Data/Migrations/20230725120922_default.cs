using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class @default : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5ca6384c-567a-4189-b288-4b5354359a00"), new Guid("194542EC-73C1-4E46-955D-A691EE6B5C21"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 25, 15, 9, 21, 894, DateTimeKind.Local).AddTicks(578), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", 15 },
                    { new Guid("c24525a7-d016-4251-8cf7-2c4e628ee066"), new Guid("194542EC-73C1-4E46-955D-A691EE6B5C21"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 25, 15, 9, 21, 894, DateTimeKind.Local).AddTicks(574), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });
             
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
             
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2683c7fb-6c1f-4892-a406-14c525b3b88a"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 25, 15, 2, 41, 48, DateTimeKind.Local).AddTicks(2108), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", 15 },
                    { new Guid("5176b18f-f2a9-490e-8549-a80410d1462a"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 25, 15, 2, 41, 48, DateTimeKind.Local).AddTicks(2103), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });
             
        }
    }
}
