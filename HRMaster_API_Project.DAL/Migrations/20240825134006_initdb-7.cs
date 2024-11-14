using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initdb7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "568d4221-6c71-4016-b241-42a1a44e6489");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9b4bcb4b-5e48-4db5-a21f-684938e49ca5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "4f11519c-c593-4a95-b49b-9ad9f65cf597");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "181cfbcf-cf5f-40f5-92e6-3b79f6b7ca40", new DateTime(2024, 8, 25, 13, 40, 4, 932, DateTimeKind.Utc).AddTicks(2927), "AQAAAAIAAYagAAAAEEEeQbep/tz5ylPAZGtO1UHzATX3VSrXJZG8EejNH4FE2pXvhhepr98qdREYfPW22A==", "bb844fa4-542f-4726-8e73-740711f17493" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f4ff779-506c-4109-8d14-e69dd67cd1bc", new DateTime(2024, 8, 25, 13, 40, 4, 998, DateTimeKind.Utc).AddTicks(4130), "AQAAAAIAAYagAAAAEPaWOWH/jAENyK8jM3qQskAKWkmqTXhkR1tV4vsZREXong0jrszwK2AgUWsZt7XWOA==", "8e0ef0ad-c2fa-437b-9bc7-e33a4969c335" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c1d1758-6831-4fc0-bace-834a8d1e0107", new DateTime(2024, 8, 25, 13, 40, 5, 72, DateTimeKind.Utc).AddTicks(3652), "AQAAAAIAAYagAAAAEEy5DtmfwJm9i0rodDR85i948eozhd6LRRun8hS+rCCPbMYcm9IEheMJ6iyeJjBv/w==", "20e1d2be-a668-468a-98b0-1f305aa3bc35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74e5d4ec-df7d-411f-8bdd-6c748f761720", new DateTime(2024, 8, 25, 13, 40, 5, 148, DateTimeKind.Utc).AddTicks(5951), "AQAAAAIAAYagAAAAEDuuxldqTIB+vht3226xmKQXpUt6goVctB4QrkrNkSc81WfMy68jmudMSzoRxWrv/g==", "e98815a4-1741-477d-b233-3caaa1448f32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "528375f0-c116-48f8-97d1-2a72eb4640c5", new DateTime(2024, 8, 25, 13, 40, 5, 235, DateTimeKind.Utc).AddTicks(7888), "AQAAAAIAAYagAAAAEBLb+K1/h+f7X2ybZbEnJPqs/vkGwTgKWlBkfP3mgjyHSd38BEfOgD7ZzFYjMNhWxA==", "764673b8-0b8f-464d-9928-86e9d2ec2d0d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthState", "BloodGroup", "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "DepartmentID", "Email", "EmailConfirmed", "EmployeeRelatedCompanyID", "Gender", "HireDate", "IdentityNumber", "Job", "LockoutEnabled", "LockoutEnd", "MarialStatus", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PicturePath", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Status", "Surname", "TerminationDate", "Title", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 6, 0, "Beşiktaş", new DateOnly(1985, 5, 20), "İstanbul", "BNegative", null, "23cc3064-fe58-4246-9479-39c0f25a60fc", new DateTime(2024, 8, 25, 13, 40, 5, 355, DateTimeKind.Utc).AddTicks(5642), null, "ayse.demir@example.com", true, null, "Female", new DateOnly(2018, 6, 15), "53245678901", "CEO", false, null, "Married", "Ayşe", "AYSE.DEMIR@EXAMPLE.COM", "AYSE.DEMIR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJcMGgAgFgTQUsehRg4v/i238oiuumatwal0glzIzYx1Xjrqcs8NCSLUQQeBD662uQ==", "+905322345678", false, "default-avatar.jpg", 9200.75m, null, null, "d9f486b6-8fd7-4113-8698-990d8d38dd9f", 1, "Demir", null, "Chief Technology Officer", false, null, "ayse.demir@example.com" },
                    { 7, 0, "Üsküdar", new DateOnly(1978, 8, 30), "Ankara", "ANegative", null, "8134737b-c829-417d-b9a1-f42de5bc0f62", new DateTime(2024, 8, 25, 13, 40, 5, 446, DateTimeKind.Utc).AddTicks(5650), null, "mehmet.kaya@example.com", true, null, "Male", new DateOnly(2016, 2, 10), "32145698700", "CFO", false, null, "Single", "Mehmet", "MEHMET.KAYA@EXAMPLE.COM", "MEHMET.KAYA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEADbJI/dDRM8/0LQPqdoVm0aPPWc49YZOwgrIzE6VdqaTURofF7qbk8ao9zCE8Ra6Q==", "+905336789012", false, "default-avatar.jpg", 9500.5m, null, null, "04347f30-c210-412e-8cb4-fe991b72467c", 1, "Kaya", null, "Chief Financial Officer", false, null, "mehmet.kaya@example.com" },
                    { 8, 0, "Taksim", new DateOnly(1990, 12, 5), "İzmir", "ONegative", null, "def574b8-e1be-4a43-9b9d-0f7c0340ec26", new DateTime(2024, 8, 25, 13, 40, 5, 523, DateTimeKind.Utc).AddTicks(3428), null, "fatma.yurt@example.com", true, null, "Female", new DateOnly(2019, 11, 22), "45678901234", "COO", false, null, "Married", "Fatma", "FATMA.YURT@EXAMPLE.COM", "FATMA.YURT@EXAMPLE.COM", "AQAAAAIAAYagAAAAECWZWKyaih+SL/XLrF69sN5qct4jLqNwwoYiiKAooJPcUU8hT00n2ssckRUieexqww==", "+905349876543", false, "default-avatar.jpg", 8800m, null, null, "fe86aa6b-d7e4-4e84-aca7-41013834f8a7", 1, "Yurt", null, "Chief Operating Officer", false, null, "fatma.yurt@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 40, 4, 925, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 40, 4, 925, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 40, 4, 925, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 40, 4, 925, DateTimeKind.Local).AddTicks(7491));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "50127a19-b07a-42ee-a17e-de8c3e3e4477");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2f6274c9-3e83-489c-9392-a18f1840a2b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "321fa789-eeeb-4581-859b-6d1fd4c3739d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "731c0670-6c13-4f09-8c4a-90ac45fd6617", new DateTime(2024, 8, 25, 13, 34, 39, 352, DateTimeKind.Utc).AddTicks(784), "AQAAAAIAAYagAAAAEMpJdcj3aJJty97eDksd0tJSLWGiuzr0sMQETKVWc2ZV02JMP4TGdyLB2vmYbcDz7w==", "a9157b02-e798-4e6c-bfb2-64c64dcc6872" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e5688cf-18af-45b6-ad36-cd8dc6d6779d", new DateTime(2024, 8, 25, 13, 34, 39, 413, DateTimeKind.Utc).AddTicks(4655), "AQAAAAIAAYagAAAAEGTMuY3XqmddxxWvdUNND5WojoD3eR17khtvl9SnNwERc1xPY0q0PcKs41yMypGXrA==", "791cf25d-cb15-4aed-a560-1381559d94d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "583d5134-81e9-47be-a7f1-0e9de3b8b3b3", new DateTime(2024, 8, 25, 13, 34, 39, 477, DateTimeKind.Utc).AddTicks(5969), "AQAAAAIAAYagAAAAEKia8dGZ8jxAUp8yKBQq3VQ4OlCRwfaIPAZ0529/AD9fmBDJuf2ejM+u9dRBYyIAyw==", "1df34e86-13c5-45e4-9304-9f2c5752acb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adfd1567-3f3d-4124-8e2c-68a872adb6db", new DateTime(2024, 8, 25, 13, 34, 39, 548, DateTimeKind.Utc).AddTicks(4477), "AQAAAAIAAYagAAAAEIlunen9S+C3g/4+z7EVvqwXO7w88REZhxkAFMOjDp8QA6s3tk9hBYFKXjcwMe9Lww==", "cbb28f4a-6162-4ec1-8a9f-4d100164bdbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3266057a-25bf-4be5-ad55-647534c03976", new DateTime(2024, 8, 25, 13, 34, 39, 614, DateTimeKind.Utc).AddTicks(8853), "AQAAAAIAAYagAAAAEDOOgVu6z7p1mQgwQqUoTJm/cY66ioy302USMVwOpK4CYwz1ZO5QqAnscsGb03fIFQ==", "867defb2-e338-4a20-a87d-3442bf7703e4" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 34, 39, 347, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 34, 39, 347, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 34, 39, 347, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 34, 39, 347, DateTimeKind.Local).AddTicks(7318));
        }
    }
}
