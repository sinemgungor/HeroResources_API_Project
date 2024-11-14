using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ınitdbCurrencyAdvanceRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Currency",
                table: "AdvanceRequests",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2c7a1e78-ff1d-41db-83c6-39507719ca5d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a2b0d0d6-cdf0-467e-8ba5-08262ee10a2e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "4000318b-a1f7-4718-9ad0-2bf7457606e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "392457ea-9392-4b03-94d0-2e79b3a96f5b", new DateTime(2024, 8, 20, 13, 18, 25, 585, DateTimeKind.Utc).AddTicks(535), "AQAAAAIAAYagAAAAEFUW3yRPru+Ercqt1aHeV7ep4MU4hcghIPqIXgiJtdR8mBBuwD3+DiRqARErqBkjJQ==", "4439426f-6128-44f8-85b2-c72e3ffe541d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cda56e4f-b451-44a7-a2c7-ffa4bdf64d26", new DateTime(2024, 8, 20, 13, 18, 25, 675, DateTimeKind.Utc).AddTicks(4756), "AQAAAAIAAYagAAAAEG6WA3RJdG1vOxl7PnO/T1wSMH8JjEWw5WrJpzJsCxQc9Zom5uQ+F3KK0UTctNbPUw==", "af57e12b-6b44-48c8-a101-11ead09e0b3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f620f9e-3530-4d73-82ca-94e5f65f10e6", new DateTime(2024, 8, 20, 13, 18, 25, 765, DateTimeKind.Utc).AddTicks(3724), "AQAAAAIAAYagAAAAEGUiq+xY1UYKowCOxO+UF/9/uTWC5BLreAePo4LUksa7gyekShqvWalGiMJaw0Iiiw==", "82c1ca49-01ae-4cba-a8f6-f2d43c328aa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72b0c222-fcc9-48db-ace6-a231c029c916", new DateTime(2024, 8, 20, 13, 18, 25, 868, DateTimeKind.Utc).AddTicks(4886), "AQAAAAIAAYagAAAAEJ89H5eA3fIA+QwaijYL3oPwu+WQ92tc1CU8QGgXc8wjT8pcXHM/FvrybKjD/UiAhA==", "c66b40ea-d77a-4aa1-b7ea-e7c0cc6789fc" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 16, 18, 25, 576, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 16, 18, 25, 576, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 16, 18, 25, 576, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 16, 18, 25, 576, DateTimeKind.Local).AddTicks(846));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "AdvanceRequests",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2c44f0b0-6bd2-4afa-8399-49060aedadb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1bc18d95-81d0-423e-bc38-666c64b74f08");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "c0baafa7-9884-4f51-8117-d1ee4557adc7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b50216ff-5c96-4ba9-9a98-d5aaa9ba1524", new DateTime(2024, 8, 20, 10, 9, 41, 104, DateTimeKind.Utc).AddTicks(363), "AQAAAAIAAYagAAAAEDp2xPA9Wx7RjfagfKkKIwDcuwsY7smr8weuT2UYIfUTPw3HUm7FvDeJ2JIhi6mGIQ==", "5bd5b7f8-21ae-4b1e-8e2b-a30e4d88257c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5935b235-ac5c-4820-8856-42f41d138d36", new DateTime(2024, 8, 20, 10, 9, 41, 165, DateTimeKind.Utc).AddTicks(2139), "AQAAAAIAAYagAAAAEE25xEOnDREW/Fl9YlRaKp7bNgtyse0hmgalgukLqOcDrbQFnLLFOVLRZbGupGb89g==", "f02f7351-1830-4c92-9392-ca4dbf1c911f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f956a17-a701-411b-8a9a-b398f868c940", new DateTime(2024, 8, 20, 10, 9, 41, 223, DateTimeKind.Utc).AddTicks(1730), "AQAAAAIAAYagAAAAELLPbc1kSp8/k9uCg5fNvagbdLkJu6VpPr4T6175pq0kRcNLtv/TJWyIIuFT0Pn9pA==", "7c5f16f1-b2a6-47da-90d0-9014861fd441" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25de9f47-5b7a-4942-98b5-e1c1c0ae31ed", new DateTime(2024, 8, 20, 10, 9, 41, 280, DateTimeKind.Utc).AddTicks(7119), "AQAAAAIAAYagAAAAEEB/vPKW+2dkRrN7QwPaNJvd/06qRBYNPsWB39Rc3d2werJX2JVwXSKjLGZKgtc3pA==", "120c358a-8868-4436-99de-b3ce828854d4" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 13, 9, 41, 97, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 13, 9, 41, 97, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 13, 9, 41, 97, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 13, 9, 41, 97, DateTimeKind.Local).AddTicks(5597));
        }
    }
}
