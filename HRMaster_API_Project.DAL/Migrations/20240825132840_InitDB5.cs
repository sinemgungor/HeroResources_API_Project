using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e17e97fd-0f65-4c71-8e4c-645701183452");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "21bee491-0a43-402a-85bd-e40f568fd8df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "b5389a1e-5486-464a-b021-7fd41bf0a483");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "BirthState", "ConcurrencyStamp", "CreationDate", "HireDate", "IdentityNumber", "Job", "PasswordHash", "PicturePath", "Salary", "SecurityStamp", "Title" },
                values: new object[] { new DateOnly(1986, 3, 15), "Bolu", "30cdb96a-4c94-434c-ab9c-5f102bc63415", new DateTime(2024, 8, 25, 13, 28, 39, 480, DateTimeKind.Utc).AddTicks(5948), new DateOnly(2019, 11, 1), "56789012345", "ADMIN", "AQAAAAIAAYagAAAAEOxfK1N7/J2Uw6wW1rqN/+EFt9UC5DIE+vaGZk9BXmvuNuRgtz9XBpllR1J7NMjDig==", "default-avatar.jpg", 8700.5m, "ad1d92b9-0806-4098-b5ab-365033b6f5aa", "Project Manager" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "BirthState", "ConcurrencyStamp", "CreationDate", "HireDate", "IdentityNumber", "Job", "PasswordHash", "PicturePath", "Salary", "SecurityStamp", "Title" },
                values: new object[] { new DateOnly(1985, 6, 20), "Gaziantep", "46e0fd12-6960-408f-9c32-9f92cc4e35de", new DateTime(2024, 8, 25, 13, 28, 39, 550, DateTimeKind.Utc).AddTicks(7087), new DateOnly(2020, 7, 15), "57890123456", "ADMIN", "AQAAAAIAAYagAAAAELz4gAAf7xsgIDEj6OrH+11+ByVtBe4LnGkl8KtbLR6BTePOQ1JXOegCa2mWSODAVA==", "default-avatar.jpg", 7900m, "f6167473-5b9e-48cc-b13e-0ea4c1c1d590", "Business Analyst" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "BirthState", "ConcurrencyStamp", "CreationDate", "HireDate", "IdentityNumber", "Job", "PasswordHash", "PicturePath", "Salary", "SecurityStamp", "Title" },
                values: new object[] { new DateOnly(1992, 10, 5), "Mardin", "78ffea21-5b1f-400f-9da4-f20fc951a091", new DateTime(2024, 8, 25, 13, 28, 39, 641, DateTimeKind.Utc).AddTicks(2628), new DateOnly(2021, 3, 1), "58901234567", "ADMINt", "AQAAAAIAAYagAAAAEBTRpmS01blOWqZKmir4vXP3n69cUU+nPrjY9YP7MLZG6Cr+atS92QbwBdb/hTskVQ==", "default-avatar.jpg", 7300.25m, "40355e5d-b273-4379-b2fd-7f405d8ff7c8", "Digital Marketing Specialist" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "BirthState", "ConcurrencyStamp", "CreationDate", "HireDate", "IdentityNumber", "Job", "PasswordHash", "PicturePath", "Salary", "SecurityStamp", "Title" },
                values: new object[] { new DateOnly(1992, 10, 5), "Mardin", "8619711f-7615-443f-9dd7-86fcc0424129", new DateTime(2024, 8, 25, 13, 28, 39, 736, DateTimeKind.Utc).AddTicks(1585), new DateOnly(2021, 3, 1), "58901234567", "ADMIN", "AQAAAAIAAYagAAAAEMqVCI9NPxEb0+w+d0JgsSbSGd4c6hy6rw7psIHMIN9JcnkuACU/oWrENiuwRAVx+A==", "default-avatar.jpg", 7300.25m, "0fadf2d8-ce27-4a5b-bfaf-104174898107", "Digital Marketing Specialist" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 28, 39, 474, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 28, 39, 474, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 28, 39, 474, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 28, 39, 474, DateTimeKind.Local).AddTicks(490));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "BirthDate", "BirthState", "ConcurrencyStamp", "CreationDate", "HireDate", "IdentityNumber", "Job", "PasswordHash", "PicturePath", "Salary", "SecurityStamp", "Title" },
                values: new object[] { null, null, "392457ea-9392-4b03-94d0-2e79b3a96f5b", new DateTime(2024, 8, 20, 13, 18, 25, 585, DateTimeKind.Utc).AddTicks(535), null, null, null, "AQAAAAIAAYagAAAAEFUW3yRPru+Ercqt1aHeV7ep4MU4hcghIPqIXgiJtdR8mBBuwD3+DiRqARErqBkjJQ==", null, null, "4439426f-6128-44f8-85b2-c72e3ffe541d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "BirthState", "ConcurrencyStamp", "CreationDate", "HireDate", "IdentityNumber", "Job", "PasswordHash", "PicturePath", "Salary", "SecurityStamp", "Title" },
                values: new object[] { null, null, "cda56e4f-b451-44a7-a2c7-ffa4bdf64d26", new DateTime(2024, 8, 20, 13, 18, 25, 675, DateTimeKind.Utc).AddTicks(4756), null, null, null, "AQAAAAIAAYagAAAAEG6WA3RJdG1vOxl7PnO/T1wSMH8JjEWw5WrJpzJsCxQc9Zom5uQ+F3KK0UTctNbPUw==", null, null, "af57e12b-6b44-48c8-a101-11ead09e0b3d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "BirthState", "ConcurrencyStamp", "CreationDate", "HireDate", "IdentityNumber", "Job", "PasswordHash", "PicturePath", "Salary", "SecurityStamp", "Title" },
                values: new object[] { null, null, "8f620f9e-3530-4d73-82ca-94e5f65f10e6", new DateTime(2024, 8, 20, 13, 18, 25, 765, DateTimeKind.Utc).AddTicks(3724), null, null, null, "AQAAAAIAAYagAAAAEGUiq+xY1UYKowCOxO+UF/9/uTWC5BLreAePo4LUksa7gyekShqvWalGiMJaw0Iiiw==", null, null, "82c1ca49-01ae-4cba-a8f6-f2d43c328aa3", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "BirthState", "ConcurrencyStamp", "CreationDate", "HireDate", "IdentityNumber", "Job", "PasswordHash", "PicturePath", "Salary", "SecurityStamp", "Title" },
                values: new object[] { null, null, "72b0c222-fcc9-48db-ace6-a231c029c916", new DateTime(2024, 8, 20, 13, 18, 25, 868, DateTimeKind.Utc).AddTicks(4886), null, null, null, "AQAAAAIAAYagAAAAEJ89H5eA3fIA+QwaijYL3oPwu+WQ92tc1CU8QGgXc8wjT8pcXHM/FvrybKjD/UiAhA==", null, null, "c66b40ea-d77a-4aa1-b7ea-e7c0cc6789fc", null });

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
    }
}
