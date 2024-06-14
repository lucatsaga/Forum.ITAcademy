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
                        onDelete: ReferentialAction.NoAction);
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
                    { "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956", 0, "c7e5c63c-392f-4ef5-8337-cfcc8bafd0a4", "User1@gmail.com", false, false, null, "USER1@GMAIL.com", "USER1", "AQAAAAIAAYagAAAAEE1+w5P0ZKpL8GaT1XH0EErWfkjKU5SNAHUPdCaCAelZUBf83cVfqzUl8o48HNvtJw==", null, false, "af61310c-e54a-40f1-bcb3-f17a149a4659", false, "User1" },
                    { "FC2DA2E8-EECC-4AC9-99F6-F3937B1EF538", 0, "2e52ce74-62fd-46e1-861e-6fb9931aba10", "User3@gmail.com", false, false, null, "USER3@GMAIL.com", "USER3", "AQAAAAIAAYagAAAAEC+cU+wT/4W9P74BmKatNU8IgZcA9t9shr7Gq1eDnhOJMJ3AVi9mySmF8sO2uu5Xtw==", null, false, "a5532302-9f8e-404b-b068-1cc8b023aae8", false, "User3" },
                    { "FC3DA2E8-EECC-4AC9-99F6-F4937B1EF538", 0, "5420f687-a603-4c70-8774-6793932be0e1", "User4@gmail.com", false, false, null, "USER4@GMAIL.com", "USER4", "AQAAAAIAAYagAAAAEKjW7gd/c3eZfHhRfBfY0ArzkwdYOh1QABE6tnV5aNrYXUQTQseaVxKI+Td1kCfdsQ==", null, false, "6114d6e7-7133-4fd4-ac78-20bd7bf846a0", false, "User4" },
                    { "FC4DA2E8-EECC-5AC9-99F6-F3937B1EF538", 0, "5b57d09a-f0cb-456c-b371-45a51c4d8e79", "User5@gmail.com", false, false, null, "USER5@GMAIL.com", "USER5", "AQAAAAIAAYagAAAAEA0P6eOBtWxY/i/Jihy89YUwEfqMiY4pEN6hnx2xj4CJphfXXs4BYmMXVTwMPomxig==", null, false, "8104ab6f-3f1a-49d9-937c-5e7ba4f1e546", false, "User5" },
                    { "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", 0, "1f322758-228c-4e0c-b37f-e652c5db9d44", "User6@gmail.com", false, false, null, "USER6@GMAIL.com", "USER6", "AQAAAAIAAYagAAAAEE0X83RYl0fS/vtXbZ+GF/DhxxSgoGRLf7jRpQC+CgOtbLI6sOM+TSmmUB7i3zSLCQ==", null, false, "b5b4ac0c-d688-48f1-bf8d-e8cd151deeed", false, "User6" },
                    { "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", 0, "ad78f04a-6537-47b3-879e-b681f354f22e", "User2@gmail.com", false, false, null, "USER2@GMAIL.com", "USER2", "AQAAAAIAAYagAAAAEAh93t+LEGxAPxGGTVAkIWeJg5gf3VQDAI94WztKq7nDKBOfelLKc0ENSpWo9AsKfQ==", null, false, "45f5818c-d3c5-4a91-aaec-08790169e919", false, "User2" },
                    { "FC6DB2E8-EECC-4AC9-99F6-F3937B1EF538", 0, "569a81f7-60a0-4d82-bced-e5f11ea81194", "User7@gmail.com", false, false, null, "USER7@GMAIL.com", "USER7", "AQAAAAIAAYagAAAAEHzcGij/Vb8YQ82rmYciOfBb7uLxJ5d6QJll3IW/GWkaU6EkcI0ug/3ILDH34dI74w==", null, false, "9ceef337-dc96-43ca-8745-203891dc66b8", false, "User7" },
                    { "FC7DC2E8-EECC-4AC9-99F6-F3937B1EF538", 0, "8be7ed8c-265c-42ec-ba44-4d95acf88b31", "User8@gmail.com", false, false, null, "USER8@GMAIL.com", "USER8", "AQAAAAIAAYagAAAAEIyA5Nf4OS4ezZLFqgAiiyr+y2c862HjRpad652tWeBq6pyZ5m+XiyyyEyT9j9YjNQ==", null, false, "b267c7f0-5581-49ba-8baf-339a8defb7cb", false, "User8" }
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
                    { 1, new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9753), "Pending", "Active", "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956", "TopicN1" },
                    { 2, new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9758), "Pending", "Active", "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956", "TopicN2" },
                    { 3, new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9759), "Pending", "Active", "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956", "TopicN3" },
                    { 4, new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9761), "Pending", "Active", "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", "TopicN4" },
                    { 5, new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9763), "Pending", "Active", "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", "TopicN5" },
                    { 6, new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9764), "Pending", "Active", "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", "TopicN6" },
                    { 7, new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9766), "Pending", "Active", "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", "TopicN7" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "CommentAuthorId", "Content", "CreatedAt", "TopicId" },
                values: new object[,]
                {
                    { 1, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "Ikomentari", new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9847), 1 },
                    { 2, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "IIkomentari", new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9849), 1 },
                    { 3, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "IIIkomentari", new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9851), 2 },
                    { 4, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "IVkomentari", new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9852), 1 },
                    { 5, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "Vkomentari", new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9859), 3 },
                    { 6, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "VIKomentari", new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9860), 3 },
                    { 7, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "VIIKomentari", new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9862), 3 },
                    { 8, "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", "VIIKomentari", new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9863), 2 }
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
