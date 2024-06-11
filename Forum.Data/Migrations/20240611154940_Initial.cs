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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBanned = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "IsBanned", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1216), "User1@gmail.com", false, false, "A123", "User1" },
                    { 2, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1222), "User2@gmail.com", false, false, "A123", "User2" },
                    { 3, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1224), "User3@gmail.com", false, false, "A123", "User3" },
                    { 4, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1226), "User4@gmail.com", false, false, "A123", "User4" },
                    { 5, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1228), "User5@gmail.com", false, false, "A123", "User5" },
                    { 6, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1229), "User6@gmail.com", false, false, "A123", "User6" },
                    { 7, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1231), "User7@gmail.com", false, false, "A123", "User7" },
                    { 8, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1233), "User8@gmail.com", false, false, "A123", "User8" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "State", "Status", "TopicName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1354), "Pending", "Active", "TopicN1" },
                    { 2, 1, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1356), "Pending", "Active", "TopicN2" },
                    { 3, 2, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1357), "Pending", "Active", "TopicN3" },
                    { 4, 2, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1358), "Pending", "Active", "TopicN4" },
                    { 5, 3, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1360), "Pending", "Active", "TopicN5" },
                    { 6, 4, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1361), "Pending", "Active", "TopicN6" },
                    { 7, 1, new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1362), "Pending", "Active", "TopicN7" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedAt", "TopicId" },
                values: new object[,]
                {
                    { 1, 1, "Ikomentari", new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1387), 1 },
                    { 2, 1, "IIkomentari", new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1389), 1 },
                    { 3, 1, "IIIkomentari", new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1390), 2 },
                    { 4, 1, "IVkomentari", new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1392), 1 },
                    { 5, 1, "Vkomentari", new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1393), 3 },
                    { 6, 1, "VIKomentari", new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1395), 3 },
                    { 7, 2, "VIIKomentari", new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1396), 3 },
                    { 8, 4, "VIIKomentari", new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1397), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TopicId",
                table: "Comments",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_AuthorId",
                table: "Topics",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
