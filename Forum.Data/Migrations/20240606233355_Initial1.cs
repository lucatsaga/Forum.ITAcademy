using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(1049), new DateTime(2024, 6, 6, 23, 33, 55, 298, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(1058), new DateTime(2024, 6, 6, 23, 33, 55, 298, DateTimeKind.Utc).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 33, 55, 298, DateTimeKind.Local).AddTicks(911));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(543), new DateTime(2024, 6, 6, 23, 24, 48, 616, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(553), new DateTime(2024, 6, 6, 23, 24, 48, 616, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 7, 3, 24, 48, 616, DateTimeKind.Local).AddTicks(414));
        }
    }
}
