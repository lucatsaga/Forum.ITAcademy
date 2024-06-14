using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TopicAuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                    table.ForeignKey(
                        name: "FK_Topics_AspNetUsers_TopicAuthorId",
                        column: x => x.TopicAuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CommentAuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_CommentAuthorId",
                        column: x => x.CommentAuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "D7AE250D-E7D5-46AB-92B5-94E96BECDAE6", null, "Admin", "ADMIN" },
                    { "D99CF9F8-F4E8-478F-BE40-5418B5D3EF8D", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956", 0, "f9ef1f49-8fe5-46ad-a5e9-0cb922e432d7", "User1@gmail.com", false, false, null, "USER1@GMAIL.com", "USER1", "AQAAAAIAAYagAAAAEE4O6ivvxMI7e1dUy19f4NPN3ZBCpOVffQgWuHOPfTaBZg+fjYDeckxj9ywREt7Ayg==", null, false, "235183a5-197e-4698-9ab7-d2f38e4cbf91", false, "User1" },
                    { "FC2DA2E8-EECC-4AC9-99F6-F3937B1EF538", 0, "b63d03c6-993d-474c-abd6-788247ae566c", "User3@gmail.com", false, false, null, "USER3@GMAIL.com", "USER3", "AQAAAAIAAYagAAAAELNYgWgZr8zNiuba/0CfWn0y7TpYv7w5iZjqeUxyZMODZfashu0M7ySl9RHX3evaGg==", null, false, "6f6aa4fd-c14a-4a67-8bf2-b989e6d3902f", false, "User3" },
                    { "FC3DA2E8-EECC-4AC9-99F6-F4937B1EF538", 0, "5b73a343-f49d-4de5-ac46-9f53b53131a1", "User4@gmail.com", false, false, null, "USER4@GMAIL.com", "USER4", "AQAAAAIAAYagAAAAENiXmk1iusPFCCka7CtNZECiRHqqr7ckxsm8iEhJW71r0YnZp//DxmPc9nE4D1uy2A==", null, false, "14a913b4-974c-48ce-b007-c64842ee8854", false, "User4" },
                    { "FC4DA2E8-EECC-5AC9-99F6-F3937B1EF538", 0, "33689a4e-cc73-4be8-8465-ac9b1a8eeef9", "User5@gmail.com", false, false, null, "USER5@GMAIL.com", "USER5", "AQAAAAIAAYagAAAAEGt+qkTCEice9wPcN4D5yBtmhYfmQBA2D4zH0tFrvRr3PvhlFBdAuCLxg/iuCcCcZg==", null, false, "2b2a51df-8197-413e-a02f-4d9701cd933d", false, "User5" },
                    { "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", 0, "4cdbc7ca-7f39-4e22-baa9-1b06688c27dd", "User6@gmail.com", false, false, null, "USER6@GMAIL.com", "USER6", "AQAAAAIAAYagAAAAEEq1DL3xAzhRqtnv4PTBQ8DnRWP+jZ46LRJFsgWSpkwsCH/UFisF+5jZ3liNJJ2WFQ==", null, false, "d2be5f4b-d45f-4d87-b3e5-f70c472bb913", false, "User6" },
                    { "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", 0, "7731f9e9-ef01-4490-9840-92fe25134fea", "User2@gmail.com", false, false, null, "USER2@GMAIL.com", "USER2", "AQAAAAIAAYagAAAAENbwxrgMkIdGWoiTZf4J1g+RFJzlQhB0nSQW7bkqtTCu6TyoQlgNILoNLfT70tx2rw==", null, false, "8ce63fe7-d83e-4f86-ae2d-ae95c2b063e0", false, "User2" },
                    { "FC6DB2E8-EECC-4AC9-99F6-F3937B1EF538", 0, "263d95d2-aca4-4475-89e9-c98828715e5e", "User7@gmail.com", false, false, null, "USER7@GMAIL.com", "USER7", "AQAAAAIAAYagAAAAEFLCsHQE3vd2n43z+0ZleobTP36iqmuqACmm5pdQAzS4r/2UjBkWYcwwnrTB4SPQ5w==", null, false, "3936a2b1-2703-4efd-b198-8bf1e8ab2635", false, "User7" },
                    { "FC7DC2E8-EECC-4AC9-99F6-F3937B1EF538", 0, "f0cd91d0-34e4-4bba-8281-1de8cd963b12", "User8@gmail.com", false, false, null, "USER8@GMAIL.com", "USER8", "AQAAAAIAAYagAAAAEOVazK44dwAJiZNg+0d/MCnkv8i2/WD6jNePQ2sFKcbzJLwQi9dk/w0OpLhYsJZvlA==", null, false, "5a3fcccc-0ad9-4451-b140-5d9a6d3676b4", false, "User8" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "D7AE250D-E7D5-46AB-92B5-94E96BECDAE6", "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956" },
                    { "D99CF9F8-F4E8-478F-BE40-5418B5D3EF8D", "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "CreatedAt", "State", "Status", "TopicAuthorId", "TopicName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(705), "Pending", "Active", "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956", "TopicN1" },
                    { 2, new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(709), "Pending", "Active", "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956", "TopicN2" },
                    { 3, new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(710), "Pending", "Active", "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956", "TopicN3" },
                    { 4, new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(712), "Pending", "Active", "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", "TopicN4" },
                    { 5, new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(713), "Pending", "Active", "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", "TopicN5" },
                    { 6, new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(714), "Pending", "Active", "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", "TopicN6" },
                    { 7, new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(715), "Pending", "Active", "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", "TopicN7" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "CommentAuthorId", "Content", "CreatedAt", "TopicId" },
                values: new object[,]
                {
                    { 1, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "Ikomentari", new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(765), 1 },
                    { 2, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "IIkomentari", new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(766), 1 },
                    { 3, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "IIIkomentari", new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(767), 2 },
                    { 4, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "IVkomentari", new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(819), 1 },
                    { 5, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "Vkomentari", new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(825), 3 },
                    { 6, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "VIKomentari", new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(826), 3 },
                    { 7, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "VIIKomentari", new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(827), 3 },
                    { 8, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "VIIKomentari", new DateTime(2024, 6, 11, 23, 35, 4, 141, DateTimeKind.Utc).AddTicks(828), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentAuthorId",
                table: "Comments",
                column: "CommentAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TopicId",
                table: "Comments",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_TopicAuthorId",
                table: "Topics",
                column: "TopicAuthorId");
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
