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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "IsBanned", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(398), "UserN1@gmail.com", false, false, "123123", "UserN1" },
                    { 2, new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(409), "UserN2@gmail.com", false, false, "123123", "UserN2" },
                    { 3, new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(412), "UserN3@gmail.com", false, false, "123123", "UserN3" },
                    { 4, new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(414), "UserN4@gmail.com", false, false, "123123", "UserN4" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "State", "Status", "TopicName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(543), 1, 1, "TopicN1", new DateTime(2024, 6, 6, 23, 24, 48, 616, DateTimeKind.Utc).AddTicks(544) },
                    { 2, 4, new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(546), 1, 1, "TopicN2", new DateTime(2024, 6, 7, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(551), 1, 1, "TopicN3", new DateTime(2024, 6, 2, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(553), 1, 1, "TopicN4", new DateTime(2024, 6, 6, 23, 24, 48, 616, DateTimeKind.Utc).AddTicks(553) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedAt", "TopicId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, "Esaa Chemi KomentariN1", new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(573), 1, new DateTime(2024, 6, 2, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, "Esaa Chemi KomentariN2", new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(575), 2, new DateTime(2024, 3, 2, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, "Esaa Chemi KomentariN3", new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(577), 3, new DateTime(2023, 6, 2, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, "Esaa Chemi KomentariN4", new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(579), 2, new DateTime(2023, 6, 2, 14, 30, 0, 0, DateTimeKind.Unspecified) }
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
