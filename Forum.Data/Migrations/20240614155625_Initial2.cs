using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66cf88b1-38a5-4671-bda2-4900b847a0b3", "AQAAAAIAAYagAAAAEOGYHyyMxg07UVq1i3NbRz8PikOlFM7MZMeQWw2NhEcownOyE7fVN3JR+objoxnVFw==", "5b2c0b3d-fc69-4ee0-955a-63c387b72d3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC2DA2E8-EECC-4AC9-99F6-F3937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f25afcca-540d-4aa4-a5fc-2fd9aa66641f", "AQAAAAIAAYagAAAAECaO7+TnMjeQyarvn9L/6DAiGdwerpctdD+HFJti7jneyt4Afo7ZIOJ9aSKOhG69WQ==", "624b3edc-9b24-4ff8-8112-a5a286aa7d70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC3DA2E8-EECC-4AC9-99F6-F4937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00debc85-b9c2-4f03-9283-70b725c16216", "AQAAAAIAAYagAAAAEJmeQtWblV5EQW0VX8CHocJqxSNIZzOlkoEPWATKiqp1Zu3c2AEsNWjsAtmx288MWg==", "6ad3034a-4c5b-4210-92b6-8b146874d65e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC4DA2E8-EECC-5AC9-99F6-F3937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a895800-34ad-4390-9ea8-78e159e005f3", "AQAAAAIAAYagAAAAEDcI7vYmYbethKMEazJc1eXWLqQShUMIWHne6wMIVoklwpLrNnM/ZaGyMwlcOAWj1A==", "d2bcefa0-b2f1-4b47-999f-44ad03661f07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49114a73-63bb-4de1-9f41-22bdcb1e6a60", "AQAAAAIAAYagAAAAED2EXd0XsOeu0ztIdRbZtwGF9oL4tjB//XCJstjPjHqBynuuOLtNXwVYQ1gVM0DciQ==", "c5ed46a2-bed5-4492-95ca-4f3d4b8ebe97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b245042-4ab8-45f1-8934-5e2ee1cc2875", "AQAAAAIAAYagAAAAEMva+SX5eT2U+UiZ4n6+n/uLPToJHFObD5EFAVtNmFwifz5DkcBe0BWw/Nv0iCEIXA==", "c0772ab7-487c-4ef2-b596-7bca2b1c3f93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC6DB2E8-EECC-4AC9-99F6-F3937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afcbb5d8-86e8-4810-af4c-9c1bec5fb2a6", "AQAAAAIAAYagAAAAEEZNE99L3B+emsIRMu7+c1ZRIcA/PLVL7BPa3tgt2UrzVwKG6G8pMzMnryUk83GHdw==", "07ebc7f6-5a02-441a-b28d-dc566e1b01da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC7DC2E8-EECC-4AC9-99F6-F3937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4011e519-217b-492b-bea4-cb1101feb0b6", "AQAAAAIAAYagAAAAEPN3lP4fa+pm6Q9MAQz/RmF5yBEcgiXXD4g7qm9j2AVUFM6Qcd+dzl+TZSAAVOVepA==", "9aed5e3f-9e78-4e03-a139-cbbf7e283d0b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "FT7DC2E8-EECC-4AC9-99F6-F3937B1EF538", 0, "14f486b8-fe4e-4e6e-b905-67a9a5880354", "adminreal@gmail.com", false, false, null, "ADMINREAL@gmail.com", "ADMINREAL@GMAIL.COM", "AQAAAAIAAYagAAAAEBISG1Jm3caZe2GQ4Kk3IZpBZAfMOgDfyJiP1iW/gwREgNFnX+tiRx1WiQAxh//RNQ==", null, false, "8b017bcd-5c4a-4e6f-b58f-b5e29290db89", false, "AdminReal@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 15, 56, 24, 817, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "D7AE250D-E7D5-46AB-92B5-94E96BECDAE6", "FT7DC2E8-EECC-4AC9-99F6-F3937B1EF538" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "D7AE250D-E7D5-46AB-92B5-94E96BECDAE6", "FT7DC2E8-EECC-4AC9-99F6-F3937B1EF538" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FT7DC2E8-EECC-4AC9-99F6-F3937B1EF538");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7e5c63c-392f-4ef5-8337-cfcc8bafd0a4", "AQAAAAIAAYagAAAAEE1+w5P0ZKpL8GaT1XH0EErWfkjKU5SNAHUPdCaCAelZUBf83cVfqzUl8o48HNvtJw==", "af61310c-e54a-40f1-bcb3-f17a149a4659" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC2DA2E8-EECC-4AC9-99F6-F3937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e52ce74-62fd-46e1-861e-6fb9931aba10", "AQAAAAIAAYagAAAAEC+cU+wT/4W9P74BmKatNU8IgZcA9t9shr7Gq1eDnhOJMJ3AVi9mySmF8sO2uu5Xtw==", "a5532302-9f8e-404b-b068-1cc8b023aae8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC3DA2E8-EECC-4AC9-99F6-F4937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5420f687-a603-4c70-8774-6793932be0e1", "AQAAAAIAAYagAAAAEKjW7gd/c3eZfHhRfBfY0ArzkwdYOh1QABE6tnV5aNrYXUQTQseaVxKI+Td1kCfdsQ==", "6114d6e7-7133-4fd4-ac78-20bd7bf846a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC4DA2E8-EECC-5AC9-99F6-F3937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b57d09a-f0cb-456c-b371-45a51c4d8e79", "AQAAAAIAAYagAAAAEA0P6eOBtWxY/i/Jihy89YUwEfqMiY4pEN6hnx2xj4CJphfXXs4BYmMXVTwMPomxig==", "8104ab6f-3f1a-49d9-937c-5e7ba4f1e546" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f322758-228c-4e0c-b37f-e652c5db9d44", "AQAAAAIAAYagAAAAEE0X83RYl0fS/vtXbZ+GF/DhxxSgoGRLf7jRpQC+CgOtbLI6sOM+TSmmUB7i3zSLCQ==", "b5b4ac0c-d688-48f1-bf8d-e8cd151deeed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad78f04a-6537-47b3-879e-b681f354f22e", "AQAAAAIAAYagAAAAEAh93t+LEGxAPxGGTVAkIWeJg5gf3VQDAI94WztKq7nDKBOfelLKc0ENSpWo9AsKfQ==", "45f5818c-d3c5-4a91-aaec-08790169e919" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC6DB2E8-EECC-4AC9-99F6-F3937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "569a81f7-60a0-4d82-bced-e5f11ea81194", "AQAAAAIAAYagAAAAEHzcGij/Vb8YQ82rmYciOfBb7uLxJ5d6QJll3IW/GWkaU6EkcI0ug/3ILDH34dI74w==", "9ceef337-dc96-43ca-8745-203891dc66b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC7DC2E8-EECC-4AC9-99F6-F3937B1EF538",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8be7ed8c-265c-42ec-ba44-4d95acf88b31", "AQAAAAIAAYagAAAAEIyA5Nf4OS4ezZLFqgAiiyr+y2c862HjRpad652tWeBq6pyZ5m+XiyyyEyT9j9YjNQ==", "b267c7f0-5581-49ba-8baf-339a8defb7cb" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 14, 14, 28, 9, 874, DateTimeKind.Utc).AddTicks(9766));
        }
    }
}
