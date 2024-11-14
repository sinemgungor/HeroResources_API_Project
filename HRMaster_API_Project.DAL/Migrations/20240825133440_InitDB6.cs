using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthState", "BloodGroup", "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "DepartmentID", "Email", "EmailConfirmed", "EmployeeRelatedCompanyID", "Gender", "HireDate", "IdentityNumber", "Job", "LockoutEnabled", "LockoutEnd", "MarialStatus", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PicturePath", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Status", "Surname", "TerminationDate", "Title", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[] { 5, 0, "Kadıköy", new DateOnly(1992, 11, 10), "Bursa", "APositive", null, "3266057a-25bf-4be5-ad55-647534c03976", new DateTime(2024, 8, 25, 13, 34, 39, 614, DateTimeKind.Utc).AddTicks(8853), null, "ali.yilmaz@example.com", true, null, "Male", new DateOnly(2020, 10, 1), "43212345312", "CEO", false, null, "Single", "Ali", "ALI.YILMAZ@EXAMPLE.COM", "ALI.YILMAZ@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDOOgVu6z7p1mQgwQqUoTJm/cY66ioy302USMVwOpK4CYwz1ZO5QqAnscsGb03fIFQ==", "+905311234567", false, "default-avatar.jpg", 8700.25m, null, null, "867defb2-e338-4a20-a87d-3442bf7703e4", 1, "Yılmaz", null, "HR Manager", false, null, "ali.yilmaz@example.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

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
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30cdb96a-4c94-434c-ab9c-5f102bc63415", new DateTime(2024, 8, 25, 13, 28, 39, 480, DateTimeKind.Utc).AddTicks(5948), "AQAAAAIAAYagAAAAEOxfK1N7/J2Uw6wW1rqN/+EFt9UC5DIE+vaGZk9BXmvuNuRgtz9XBpllR1J7NMjDig==", "ad1d92b9-0806-4098-b5ab-365033b6f5aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46e0fd12-6960-408f-9c32-9f92cc4e35de", new DateTime(2024, 8, 25, 13, 28, 39, 550, DateTimeKind.Utc).AddTicks(7087), "AQAAAAIAAYagAAAAELz4gAAf7xsgIDEj6OrH+11+ByVtBe4LnGkl8KtbLR6BTePOQ1JXOegCa2mWSODAVA==", "f6167473-5b9e-48cc-b13e-0ea4c1c1d590" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78ffea21-5b1f-400f-9da4-f20fc951a091", new DateTime(2024, 8, 25, 13, 28, 39, 641, DateTimeKind.Utc).AddTicks(2628), "AQAAAAIAAYagAAAAEBTRpmS01blOWqZKmir4vXP3n69cUU+nPrjY9YP7MLZG6Cr+atS92QbwBdb/hTskVQ==", "40355e5d-b273-4379-b2fd-7f405d8ff7c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8619711f-7615-443f-9dd7-86fcc0424129", new DateTime(2024, 8, 25, 13, 28, 39, 736, DateTimeKind.Utc).AddTicks(1585), "AQAAAAIAAYagAAAAEMqVCI9NPxEb0+w+d0JgsSbSGd4c6hy6rw7psIHMIN9JcnkuACU/oWrENiuwRAVx+A==", "0fadf2d8-ce27-4a5b-bfaf-104174898107" });

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
    }
}
