using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initdb14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bd578d76-e17b-4284-855f-6214dba5ea5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "74d6e148-561f-42bb-a7a0-0e59771bd1c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e3e30850-3697-4f67-b7b1-1fb8131d4339");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23166da6-fc92-4d71-9943-ce79fad5818f", new DateTime(2024, 8, 25, 14, 7, 27, 640, DateTimeKind.Utc).AddTicks(4769), "AQAAAAIAAYagAAAAEKGoXodpm2aaxsGhliJA2tRYBYqjtYhrG/t8YsQuastm5vJ1xtnhylbbwv6DE+aZzA==", "09a3cabe-5ed3-4c5a-9165-958594e3e336" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab04aaa6-8587-4263-afb5-7d7ff26c96e4", new DateTime(2024, 8, 25, 14, 7, 27, 713, DateTimeKind.Utc).AddTicks(5523), "AQAAAAIAAYagAAAAEJptE4BSv/VcLGARrAGWTAg20VAwqIeQ7gaxOaV91aQc9QmOis2xa9xPm5PQ2Z6jpg==", "69423995-1ede-4de2-ace8-70ae1e69d4d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0698614e-a186-418e-872f-794841b4c143", new DateTime(2024, 8, 25, 14, 7, 27, 783, DateTimeKind.Utc).AddTicks(8348), "AQAAAAIAAYagAAAAEOsccwp5LcOwMlExEw/jvl/G3LQjLYgNeYE1YhNEKUTSsGYxPbEjXu12wMhNkKZovA==", "58210d97-9f69-416c-be22-885d644d2182" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74ba5018-fe2a-4940-8c1d-6b33fb74787b", new DateTime(2024, 8, 25, 14, 7, 27, 858, DateTimeKind.Utc).AddTicks(2221), "AQAAAAIAAYagAAAAENjXJjj3CZJQKS5iZ/REY6MJDu53tsXhPodCh4G6k/QFMMZ3gdP/cUlFTPWebHbCYA==", "731dcbfd-7a78-4ac3-b0d2-cc5ccaf35ff2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e12eb56-2687-4d78-9a5e-4a03d1af030b", new DateTime(2024, 8, 25, 14, 7, 27, 929, DateTimeKind.Utc).AddTicks(5944), "AQAAAAIAAYagAAAAELu1btjjAW3oYbQXJ5ITZBkjFnuFy4CELGni/qYwa5Ia5a3jAOIqAOs0uH2wPFH7Xg==", "f24fc884-c3b2-4f63-8e78-a19a014c0f5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "554b4e19-a7f2-4764-bd2c-25930be1a420", new DateTime(2024, 8, 25, 14, 7, 27, 995, DateTimeKind.Utc).AddTicks(2241), "AQAAAAIAAYagAAAAENtNhKMefnCG/vpAxtSpmJna5y0lxw70nUBfD3eAAqKw9o/Y3KJNY06yeWyb+hGKxw==", "bacb0a8b-a96f-40df-87e4-3eed6bebd69e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe16aef2-24b9-4e7e-8dae-3fe80d184a52", new DateTime(2024, 8, 25, 14, 7, 28, 66, DateTimeKind.Utc).AddTicks(4068), "AQAAAAIAAYagAAAAEEUfZ/cLl4Y22bMRz7IlaVJ+vYT+Wd1oAEdAt4xdvsJtqog2Z5203QmcSZPog3AGGw==", "f84251c5-2cfd-49b3-a9dc-fb2cf33d9cc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf74c442-a428-4c7c-bbe0-3b6fa9d64033", new DateTime(2024, 8, 25, 14, 7, 28, 139, DateTimeKind.Utc).AddTicks(7875), "AQAAAAIAAYagAAAAEIf3QOF06DXQDGeWO0vTa3WgiCUv4bif19TQWqqfVLWezKK3RV4MqCT59kzX97CCFg==", "81f62a20-3ffd-439e-9d30-544494e33432" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb7c5d7a-d3c1-4fc3-88c8-8e410a80d84e", new DateTime(2024, 8, 25, 14, 7, 28, 209, DateTimeKind.Utc).AddTicks(3304), "AQAAAAIAAYagAAAAEMg+KWHQLmsIJHjG8eLYZT+5hHmuzbUoCXTvJcZlebkL41/KtfGpQ7jKQIbeLuQO7A==", "110bd563-c866-4176-8384-36f67787d9b0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthState", "BloodGroup", "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "DepartmentID", "Email", "EmailConfirmed", "EmployeeRelatedCompanyID", "Gender", "HireDate", "IdentityNumber", "Job", "LockoutEnabled", "LockoutEnd", "MarialStatus", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PicturePath", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Status", "Surname", "TerminationDate", "Title", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 10, 0, "Etiler", new DateOnly(1993, 2, 18), "İzmir", "OPositive", null, "bd83bdf1-5a19-46d0-92d4-0f08553eb8de", new DateTime(2024, 8, 25, 14, 7, 28, 285, DateTimeKind.Utc).AddTicks(9573), null, "elif.koc@example.com", true, 3, "Female", new DateOnly(2019, 1, 20), "12365478901", "Project Manager", false, null, "Single", "Elif", "ELIF.KOC@EXAMPLE.COM", "ELIF.KOC@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKUBDgOJg+D5eLfGjQtfMFrfJTnZInIw4AGe0+9YY/mJn9H8gFrLSQmmkypGMb63QA==", "+905355678901", false, "default-avatar.jpg", 8000.75m, null, null, "8a914a9f-e9df-478f-a298-e6a531dfb64f", 1, "Koç", null, "Manager", false, null, "elif.koc@example.com" },
                    { 11, 0, "Bakırköy", new DateOnly(1988, 12, 30), "Antalya", "ANegative", null, "0b7e6a09-d682-431a-a675-67bf29d210d7", new DateTime(2024, 8, 25, 14, 7, 28, 378, DateTimeKind.Utc).AddTicks(1697), null, "ahmet.ozturk@example.com", true, 3, "Male", new DateOnly(2020, 5, 5), "98765432109", "Data Analyst", false, null, "Married", "Ahmet", "AHMET.OZTURK@EXAMPLE.COM", "AHMET.OZTURK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPUSJHlq9G72r92ZhDFdjiKjqtLqD9w57I76zhAJhdb16RvNYJtSdx75UjwDzN5SFg==", "+905399876543", false, "default-avatar.jpg", 7200m, null, null, "b48520e4-47e9-40ff-9522-f78ae4e9f3b2", 1, "Öztürk", null, "Analyst", false, null, "ahmet.ozturk@example.com" },
                    { 12, 0, "Beylikdüzü", new DateOnly(1995, 7, 10), "Adana", "BPositive", null, "9259cc6b-d9ac-4ce2-a3d7-2ca2731fc47c", new DateTime(2024, 8, 25, 14, 7, 28, 444, DateTimeKind.Utc).AddTicks(8817), null, "zeynep.arslan@example.com", true, 3, "Female", new DateOnly(2022, 3, 1), "67890123456", "Marketing Specialist", false, null, "Single", "Zeynep", "ZEYNEP.ARSLAN@EXAMPLE.COM", "ZEYNEP.ARSLAN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPoZ+EVR3cMuc7i74DYUUzDVj0EikeYoRXuXTem+n9I+Fch3Icnb1XpvWXad2DX5yg==", "+905366543210", false, "default-avatar.jpg", 6800.3m, null, null, "a488ce02-54c0-4b1e-ace6-870c0cca53d8", 1, "Arslan", null, "Specialist", false, null, "zeynep.arslan@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 17, 7, 27, 630, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 17, 7, 27, 630, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 17, 7, 27, 630, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 17, 7, 27, 630, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f161e23d-6cd3-4b6b-8fc0-bce5d23b9ea5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4f607662-0902-4cf4-add5-e8474ccd8937");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b9bcc679-ee36-4e77-ad1d-e2bec5fbead5");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7189071-a403-4254-8928-2275dd9adb2d", new DateTime(2024, 8, 25, 14, 2, 29, 595, DateTimeKind.Utc).AddTicks(8822), "AQAAAAIAAYagAAAAEAtzyVXr3MwrItZ/xODbgaRTgGsncsVVCoebi1CpkMskynTyWXEEGlBmYUhTWoHDxQ==", "7e477145-1dbf-414b-ab91-5075629df0de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f643806c-faad-4e9b-81ca-f9e461dd9650", new DateTime(2024, 8, 25, 14, 2, 29, 702, DateTimeKind.Utc).AddTicks(9050), "AQAAAAIAAYagAAAAEIV3dqxPuSD3K9A6RpRga5ZtP3k099lEo39R0yLMECnylf9WcF4Q7cRmvZHpJ8V7mg==", "f9a5aa7c-7cde-4ade-8166-6fca9b6f55a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d10e33d2-3cf3-4164-8258-51cd88b84390", new DateTime(2024, 8, 25, 14, 2, 29, 840, DateTimeKind.Utc).AddTicks(5371), "AQAAAAIAAYagAAAAENhFuBImxDp4OfmzUiB/4KYMWZd4SMn2Brv7kAStBll9qurh4D9wtnvockuJOnBAng==", "72c42f18-1a28-4b46-8c15-99bf3b18d769" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5877219-82b2-4f60-82d8-d4ad990ad081", new DateTime(2024, 8, 25, 14, 2, 29, 969, DateTimeKind.Utc).AddTicks(2867), "AQAAAAIAAYagAAAAEKWWMxTOzNWXaufpMAvi2YA0sM1JtEGIjI4WhprkdqNlkMlXIfW56ZCm7IodfbxJUA==", "07063039-1b97-4ed9-968c-6394fc245530" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2444983-1e83-4f83-b974-81aa4a64a883", new DateTime(2024, 8, 25, 14, 2, 30, 90, DateTimeKind.Utc).AddTicks(3084), "AQAAAAIAAYagAAAAECBJGLZ07PoN3Ked0srnbC11NGHj5K5M31EGjnsjdrheS5TwvI+eX3RF4Hb7Jr1RsA==", "c205663f-9200-422b-9f4b-96d29a02ffe4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "295fe16e-c8a3-4c18-a3ad-7821968411ae", new DateTime(2024, 8, 25, 14, 2, 30, 205, DateTimeKind.Utc).AddTicks(3456), "AQAAAAIAAYagAAAAEA8n9iakVY/ayazhZmTK3M0dRK4cuzFgY4sZo8Bb3u07LE8KbK1YWQuOa1qeCZ2jtg==", "c2748977-fa33-465b-819e-e4b6d69bb385" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a22aeb9-8298-41ee-8588-95e4612f5593", new DateTime(2024, 8, 25, 14, 2, 30, 329, DateTimeKind.Utc).AddTicks(6743), "AQAAAAIAAYagAAAAEBmwW+kpWpNTccV+rytWkjQs4bEFvfrSNCg8kEuixsmXrZ/ovgtmU6eTFQbQfePKkg==", "2ca812fc-130c-43a1-9691-104f5c84de53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d34fb9e-4144-4695-83ca-8de2a916be72", new DateTime(2024, 8, 25, 14, 2, 30, 444, DateTimeKind.Utc).AddTicks(884), "AQAAAAIAAYagAAAAEAMfNPiQthvBcIUklqA0MhjCkLnl3eiuXedq21CUslk8MR2Er83Y3Qd1fG/z3EaQHA==", "a77df515-1894-43a3-b8a6-1c744cc7b289" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbd10981-8f50-492a-b6d4-85ced66594ea", new DateTime(2024, 8, 25, 14, 2, 30, 542, DateTimeKind.Utc).AddTicks(9243), "AQAAAAIAAYagAAAAEK4hGSY18rAzgfFifq9NJABb6GxuGOck5iCnL61bTEo0tte+iOGUMv7SGXIpNgZGEQ==", "2b9dd778-572c-4fc5-b8ea-cd8717ac430d" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 17, 2, 29, 587, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 17, 2, 29, 587, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 17, 2, 29, 587, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 17, 2, 29, 587, DateTimeKind.Local).AddTicks(1981));
        }
    }
}
