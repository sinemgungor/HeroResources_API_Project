using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, "b9bcc679-ee36-4e77-ad1d-e2bec5fbead5", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 3, 8 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ed3a230e-c7cd-4c98-932a-31bdb6b80e06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5e21aaba-8887-4335-9023-22fa6abe2c98");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 4, "60204a97-1886-45c0-8da3-519e886d1e0f", "Employee", "EMPLOYEE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5641321-55f9-477e-8030-e0c3402226fb", new DateTime(2024, 8, 25, 13, 58, 56, 240, DateTimeKind.Utc).AddTicks(2896), "AQAAAAIAAYagAAAAEKuYCnt8qDs81Dq4P8v7ENJfH6UMceCT67sQ/YF1ltnB4bHdbc4z794P/kvWlzQyMA==", "812e4ff1-16fc-4091-82fa-90be17029059" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "650042c4-7d55-4164-b4f4-5b581a4d0715", new DateTime(2024, 8, 25, 13, 58, 56, 312, DateTimeKind.Utc).AddTicks(267), "AQAAAAIAAYagAAAAED2yaTqoJG5TYAZez48qn3QSqOvb/ZP5KZmCYtrv4ylxZacHCBG7yNJUJ7paWRMdwQ==", "bf2f4a9a-2e38-4cec-9cc0-adcfc98ea879" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395c82d0-9a0f-48bb-b1c4-4d47ec8577e2", new DateTime(2024, 8, 25, 13, 58, 56, 399, DateTimeKind.Utc).AddTicks(685), "AQAAAAIAAYagAAAAEIX0UguC1VuKoOx4uucPMHOs22kVG0VeMCyjhM+V/tRUI16z6IcN0wsh2k3K0H3iiQ==", "e010e4e0-2a95-4e3a-b478-e36412eb46a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "026ba4ec-25d4-40b1-9d4f-76c3bd64b0b2", new DateTime(2024, 8, 25, 13, 58, 56, 494, DateTimeKind.Utc).AddTicks(6188), "AQAAAAIAAYagAAAAEOQmRJgWX7k8Ho5U5vfUfsARMkZ5dCqNu1wCv+A28Va4poRKI1K7fkTslJGAUpa7SQ==", "bd9ba8c6-4f6e-4a5f-973c-ba86d7d8e1e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b5557dd-f2a3-47a3-8f78-d1ed4d6f0907", new DateTime(2024, 8, 25, 13, 58, 56, 589, DateTimeKind.Utc).AddTicks(5668), "AQAAAAIAAYagAAAAELKY1c2aqGja3fBrc9gfYeJySSgvD8p/yJ/gvayOrUFwFRl+J+53C7Ag5QzEDbcj3Q==", "6a978af3-5657-4511-968e-d434fc14a99d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2c4adbd-cbb8-41d5-8f7c-43ce3bb18f97", new DateTime(2024, 8, 25, 13, 58, 56, 711, DateTimeKind.Utc).AddTicks(1533), "AQAAAAIAAYagAAAAEJcHZ8UQ4nO8T+AH3pISGYMf2uVakKfFgVKeURaH/TWdl+cm5pl8MunylZ4iFv7D+Q==", "015dd7d4-d209-4d7b-b181-448d1208aba5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b7d2f22-c788-4353-9b1a-9fd30f6c6dec", new DateTime(2024, 8, 25, 13, 58, 56, 816, DateTimeKind.Utc).AddTicks(1242), "AQAAAAIAAYagAAAAEE89g++ZpBbA4bZKjfgVK/m6iXLAu1n6VTBFXSFy8iXzRgdqpSOtFlKn3o/leiV9xw==", "61ca6cf5-b3ef-4247-8330-3a7ec3c2cd83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b23014cb-2f9b-427b-b9e1-1d8c2fe8791f", new DateTime(2024, 8, 25, 13, 58, 56, 925, DateTimeKind.Utc).AddTicks(3837), "AQAAAAIAAYagAAAAENfJBPPt17kh30SQwVJ0ZSMxwnpIwNFF3i45G6LAEIFwMBiYeGyEr9sjxBVS0Lrv3Q==", "549a0602-a730-49fe-bf4b-a29f7f753907" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd4eefd3-aa49-425f-b766-0a2e41963693", new DateTime(2024, 8, 25, 13, 58, 57, 47, DateTimeKind.Utc).AddTicks(7387), "AQAAAAIAAYagAAAAENm/AbK3v5NgAfmu9SKymK1/SnliZY7iLuxOrCAE42+RNugmUwJ//8+TAYJCWIuJqQ==", "14a8f619-f8ab-4111-bee0-f8c1a53b50a0" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 58, 56, 233, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 58, 56, 233, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 58, 56, 233, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 58, 56, 233, DateTimeKind.Local).AddTicks(8506));
        }
    }
}
