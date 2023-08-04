using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "personels");

            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("061415e8-cdc1-4106-8e23-c9001a7478a5"));

            //migrationBuilder.DeleteData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: new Guid("39d53acc-02a1-4e57-9374-91f001d88c69"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.InsertData(
            //    table: "Articles",
            //    columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
            //    values: new object[,]
            //    {
            //        { new Guid("a457d502-b0f9-490f-bcf0-02286a72af2c"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(1964), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", 15 },
            //        { new Guid("d5744c63-0e69-46fe-9432-53fd1de06438"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(1959), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
            //    });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), "1dcdc364-57ca-4451-85c6-dc591adaa70d", "Superadmin", "SUPERADMIN" },
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), "c3b219c9-a258-4b0e-b98d-446dec14acfb", "Admin", "ADMIN" },
                    { new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"), "ba63475f-cb58-424e-808b-e1b57b219634", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 0, "7d8cd9c9-23d0-4b58-9469-4a6bf27b4e9a", "admin@gmail.com", false, "Admin", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPy1KKNspuN9dmODpfwUMzP0wH2650I0CMtFYxLxXIYhrq/mIyREURruXW4ZvkmoJQ==", "+905439999988", false, "38d0ef54-88fa-4e45-85a1-aa45f2da5108", false, "admin@gmail.com" },
                    { new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 0, "44265f62-9bef-44d9-8694-ec7348d6da1b", "superadmin@gmail.com", true, "irem", "topcam", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGPEBvkpAy2viZ518ZanAQozP4KYCFMrwKhg28nfRBV8WC58gDOZlnOBrHvrgriqdQ==", "+905439999999", true, "ccedc756-133c-4c87-a1cc-73bf08c653a0", false, "superadmin@gmail.com" }
                });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("22cd830c-16c4-4ac1-9d1f-8e0b0686ad68"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(2620));

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(2608));

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("9c41643f-a6af-4621-8110-82bc6254aad8"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(2701));

            //migrationBuilder.UpdateData(
            //    table: "Images",
            //    keyColumn: "Id",
            //    keyValue: new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"),
            //    column: "CreatedDate",
            //    value: new DateTime(2023, 7, 31, 10, 28, 12, 333, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_UserId",
                table: "AspNetRoleClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_RoleId",
                table: "AspNetUserClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a457d502-b0f9-490f-bcf0-02286a72af2c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d5744c63-0e69-46fe-9432-53fd1de06438"));

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("061415e8-cdc1-4106-8e23-c9001a7478a5"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "Visual Studio lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 26, 15, 53, 48, 708, DateTimeKind.Local).AddTicks(1558), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Visual Studio  Deneme Makalesi 1", 15 },
                    { new Guid("39d53acc-02a1-4e57-9374-91f001d88c69"), new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"), "lorem ipsum lalalalalalaalaala", "Admin Test", new DateTime(2023, 7, 26, 15, 53, 48, 708, DateTimeKind.Local).AddTicks(1542), null, null, new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22cd830c-16c4-4ac1-9d1f-8e0b0686ad68"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 26, 15, 53, 48, 708, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d79233c4-26fd-4c4c-b51a-140d7bc62d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 26, 15, 53, 48, 708, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9c41643f-a6af-4621-8110-82bc6254aad8"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 26, 15, 53, 48, 708, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("af8e62f4-0625-4aaa-b3b1-29e13c8c59b5"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 26, 15, 53, 48, 708, DateTimeKind.Local).AddTicks(1793));
        }
    }
}
