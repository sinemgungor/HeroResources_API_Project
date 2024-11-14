using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "60204a97-1886-45c0-8da3-519e886d1e0f");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthState", "BloodGroup", "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "DepartmentID", "Email", "EmailConfirmed", "EmployeeRelatedCompanyID", "Gender", "HireDate", "IdentityNumber", "Job", "LockoutEnabled", "LockoutEnd", "MarialStatus", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PicturePath", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Status", "Surname", "TerminationDate", "Title", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[] { 9, 0, "Kadıköy", new DateOnly(1990, 9, 15), "Ankara", "ABPositive", null, "cd4eefd3-aa49-425f-b766-0a2e41963693", new DateTime(2024, 8, 25, 13, 58, 57, 47, DateTimeKind.Utc).AddTicks(7387), null, "mert.kaya@example.com", true, 3, "Male", new DateOnly(2021, 4, 10), "78901234567", "Software Developer", false, null, "Single", "Mert", "MERT.KAYA@EXAMPLE.COM", "MERT.KAYA@EXAMPLE.COM", "AQAAAAIAAYagAAAAENm/AbK3v5NgAfmu9SKymK1/SnliZY7iLuxOrCAE42+RNugmUwJ//8+TAYJCWIuJqQ==", "+905341234567", false, "default-avatar.jpg", 7500.5m, null, null, "14a8f619-f8ab-4111-bee0-f8c1a53b50a0", 1, "Kaya", null, "Junior Developer", false, null, "mert.kaya@example.com" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c7fefe64-de6e-4e71-8657-42b96817d203");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7b7f9afa-6230-49ea-9b72-cc9107a1f777");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "74db65f5-fef3-488a-8280-700fde739df2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "042d9ee9-ab2e-4b7c-9cd2-a96a6015833a", new DateTime(2024, 8, 25, 13, 54, 45, 489, DateTimeKind.Utc).AddTicks(1402), "AQAAAAIAAYagAAAAEOfk6VkFNdSB8bgpYtzSqf9vjLcNAm9WKiiP2p2nTdz9Th3GZLuHU3a1FC2wrrrYSw==", "ddb885a3-e55b-44f4-b751-c21c09f79fde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3722ce61-805c-4a6e-b06d-6f0450eb5950", new DateTime(2024, 8, 25, 13, 54, 45, 554, DateTimeKind.Utc).AddTicks(6771), "AQAAAAIAAYagAAAAEKuIkNgBYtx6lwd7rmKqbinVLedRT794STeuGqDYvNehenYw0pan4SXmo2zfqd/emA==", "12552b2d-792a-48cc-874c-d0f054a9cd19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e77e4d93-a223-41b8-9150-f33fae602237", new DateTime(2024, 8, 25, 13, 54, 45, 651, DateTimeKind.Utc).AddTicks(6415), "AQAAAAIAAYagAAAAECDX/WZYQ+A2ko3jxW9RxwfT+juix5+HK/yJ5Ypmaka/YzWZielJe/F9KLfZwBLslA==", "fed11aaa-1174-4708-a3e3-02d02b24fb57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de0b4582-bd5f-4643-92c5-2ac82a677780", new DateTime(2024, 8, 25, 13, 54, 45, 743, DateTimeKind.Utc).AddTicks(3131), "AQAAAAIAAYagAAAAEP2049I+fmEGs35c35dzxZ7N9YEasA56L+yKqT31cHBmuTTzvr8DrTeNhh6rWA2ZXw==", "27d43f0d-7312-49da-929f-7384491a1501" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52aa71b5-de4e-4fa4-9b03-a30a50bb88fb", new DateTime(2024, 8, 25, 13, 54, 45, 836, DateTimeKind.Utc).AddTicks(2500), "AQAAAAIAAYagAAAAEO7doUfloGcLYaQX+aGdVKh2acoCbLkg+0eza0UyrbXRzC7elpMTm1qEWlP9/7l8BA==", "4c4e27a1-8a0c-4a89-8e9d-1ac5bd61e5df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ad01330-587e-4b76-97d4-8ca0b360692d", new DateTime(2024, 8, 25, 13, 54, 45, 928, DateTimeKind.Utc).AddTicks(2722), "AQAAAAIAAYagAAAAEI7VvqXVXBXjcS11UM5Ew5A1daA0C81vwY+vlGH+amAvTjZso9l/aZ4kFVHvDP2vqw==", "96a3770b-e219-4a93-971f-eea7d260e52e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6976e1a4-8e52-4b36-866a-1a60de908e34", new DateTime(2024, 8, 25, 13, 54, 46, 8, DateTimeKind.Utc).AddTicks(9), "AQAAAAIAAYagAAAAEKF7gu3aF4yGoGYvHdgVKvcAN55WAOjPzqZDZoo3fGR3Yj62PLWaBw5s+rbOeDa+Qg==", "56918ae0-bb17-47bf-a5f1-3aa7735b199f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01e6f6f9-5a92-4f58-8155-dac5d1a96ad7", new DateTime(2024, 8, 25, 13, 54, 46, 93, DateTimeKind.Utc).AddTicks(2448), "AQAAAAIAAYagAAAAEM8BOuaaQxFR2iPa56in5tHeF/uMaw3N8a1321t5Z/9N+kVtj4G4czNCOyuTsbP10Q==", "bd580447-d253-45da-a47b-4886f1a58e73" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 54, 45, 483, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 54, 45, 483, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 54, 45, 483, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 54, 45, 483, DateTimeKind.Local).AddTicks(5870));
        }
    }
}
