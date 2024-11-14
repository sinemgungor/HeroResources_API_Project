using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "df0f6a8a-7193-4244-ab94-7f4b974efdc2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e68553d6-6550-4af5-8847-e0b7abe1490f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "469330fe-5718-41e3-aed3-529bc00a97ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "028860f8-a880-42c1-9435-573c430153c2", new DateTime(2024, 8, 25, 13, 49, 17, 480, DateTimeKind.Utc).AddTicks(9402), "AQAAAAIAAYagAAAAECMy6gF94BWYZhBXEsYD8tWxUvwlO8laMo+WMcHiUCevN80/jWSA4N/kc22wJDGQeg==", "e28c5b79-0458-4b15-a0ec-6a47bfd729a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a09742c8-c42c-4501-b230-c37cb12d4ae6", new DateTime(2024, 8, 25, 13, 49, 17, 566, DateTimeKind.Utc).AddTicks(9191), "AQAAAAIAAYagAAAAEHb0VCnehokNb+ao5CkHY23JXltkERGqoJaUd6a1bHponm6jbdsOvFNgIrgKcYB9qQ==", "e5bac0b0-3ecc-4e8e-8524-146f63dd380a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35896b5b-a9de-42f3-8494-53972ce53fc8", new DateTime(2024, 8, 25, 13, 49, 17, 662, DateTimeKind.Utc).AddTicks(3567), "AQAAAAIAAYagAAAAEGKKMpZhmO83rCZL3TV2sEA3rwLxfXeYACfg6J01Pba5XxOAn3NOJpKgFMc7wSjtIQ==", "4c53f19b-ba39-4f9c-ada0-ff63fe4c1127" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9469c56d-5796-4ed1-8079-a682644f1c1d", new DateTime(2024, 8, 25, 13, 49, 17, 761, DateTimeKind.Utc).AddTicks(3142), "AQAAAAIAAYagAAAAEBPVZRdcILD6EBg9k7AhkNzMYrp4aqmAxwp5LoVZvJcj1cXO+MgIXgFtK9BIDZuI/w==", "d9429181-620a-42e2-9e20-7b716004401b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { 1, "b80685a8-d68c-4c66-8213-4753fe3352ad", new DateTime(2024, 8, 25, 13, 49, 17, 840, DateTimeKind.Utc).AddTicks(9075), "AQAAAAIAAYagAAAAEE8cyshVTzFfUmxoME90QGcwKi02iH8OJX49K2vW3NHWxX0wU0yMxYIB4DDjv8GUmw==", "1a42d0ec-24fb-41a8-97b2-1d012d7cf282" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { 2, "acc86d50-2f6e-48b4-85a0-a4e36061c404", new DateTime(2024, 8, 25, 13, 49, 17, 930, DateTimeKind.Utc).AddTicks(6128), "AQAAAAIAAYagAAAAEKjSj3bWlGEven3CBBkMDV0FjM/8qpBwCNnh+qS0nw3FpiBZPOk+mVucwz2j8m1xTQ==", "5dee77dc-6000-44d9-b381-1f9e66adfe15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { 3, "e6883ccd-0793-4060-afa6-3a3b1c136e96", new DateTime(2024, 8, 25, 13, 49, 18, 1, DateTimeKind.Utc).AddTicks(1753), "AQAAAAIAAYagAAAAEKx5ukMNdBUM8cb5h0U/tSJzpUb+WmOi5diycsvNB7HnrqxMOg9sYEPQeH5vxaq3lQ==", "0ed40309-7382-4ac5-a6d8-61edfb555b2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { 4, "e1dcf26e-cc61-4685-8fde-c506fe27c3fb", new DateTime(2024, 8, 25, 13, 49, 18, 93, DateTimeKind.Utc).AddTicks(1419), "AQAAAAIAAYagAAAAEOpAcAFZqVCtipsfJjrHNyjeq7YB/o4KHt54GX80mLq0VQi5EFcCozW8KjmbIWmYLA==", "c08be30e-1f02-4e24-9387-f18eefff6692" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 49, 17, 472, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 49, 17, 472, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 49, 17, 472, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 49, 17, 472, DateTimeKind.Local).AddTicks(8531));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "27a8356d-45c5-4a8a-9993-74707d3fc79e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f862e786-978d-47c0-8739-9b5fdefb68a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "17637388-a984-4cbe-97a0-ecdfc7614681");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ec4e712-1390-4d11-b1a6-ccc5e3620c4e", new DateTime(2024, 8, 25, 13, 46, 51, 837, DateTimeKind.Utc).AddTicks(1973), "AQAAAAIAAYagAAAAEKTyKs7F94w+6JYrm8ZRbpK2KWpOnqaHlHoexDyQ+kW1T1ALWS6KVzjxAe4V4D3YYQ==", "1c774d37-948b-45b0-834f-0cfbcdb82915" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84c55124-203f-49f8-9e77-851e9a893b99", new DateTime(2024, 8, 25, 13, 46, 51, 901, DateTimeKind.Utc).AddTicks(6972), "AQAAAAIAAYagAAAAEGTZ7AmlCFhpO8Aykz0F7WspNMc7T5YHcrb52V1MyKuVnhuIqRA8VT3SFw8GRkusig==", "1b9fdf62-86c2-4c00-b7d1-bbcaba964381" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d688d702-dcba-4d7e-b999-5acf2aeac1fb", new DateTime(2024, 8, 25, 13, 46, 51, 971, DateTimeKind.Utc).AddTicks(5550), "AQAAAAIAAYagAAAAEOCjBiGFKL0EZyoKBEG7l6Rgv7E+GBpVFO/cVf/lU1TikvhtFX509Y+p/TfFdDZzjg==", "dcc697ba-30f1-42b6-8ffe-33960af20de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "849acbcd-c446-43a8-afdd-396b11a7724c", new DateTime(2024, 8, 25, 13, 46, 52, 49, DateTimeKind.Utc).AddTicks(7799), "AQAAAAIAAYagAAAAEA74Y4upG55PX2oIl0m8OlxxguIIJK1DeZSYVZW5HIJgcMB6wtw0al66rkniU4nAKQ==", "96e87547-1bb5-4a9d-a000-b90266ae799f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "e89f1ef2-b86c-4318-990b-be8381b0db5a", new DateTime(2024, 8, 25, 13, 46, 52, 129, DateTimeKind.Utc).AddTicks(9918), "AQAAAAIAAYagAAAAEHX7i61Eit5nu+PLkjtPMImGNL1myaeHWD9x6Rd8qZXaPikRsTATAlgY7pghlQiVLA==", "8dcede66-7159-4678-8f01-e73e35f954b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "4df0c360-4d08-4199-b967-31b078dbadf7", new DateTime(2024, 8, 25, 13, 46, 52, 211, DateTimeKind.Utc).AddTicks(9628), "AQAAAAIAAYagAAAAELFYtN42Js1+lU+wZ1DrhYAUSWXHjJ3Ie6YVd9S7+qPxJUmRi+D6DacycNfmg7QDrg==", "044914df-ecfb-476b-8af4-9bf19a762608" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "996017dc-4214-4497-aa2a-7893b9b2dbd0", new DateTime(2024, 8, 25, 13, 46, 52, 285, DateTimeKind.Utc).AddTicks(3799), "AQAAAAIAAYagAAAAEJ4Le9Xlag5Cp/jULcUrfpJuUZOiLgl7xKMIKwxZSNHnHeOjGquYHwY2K8bEvOjL1g==", "bf47ae60-84fc-47b9-9b39-7aecf4131215" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "eca9e664-524d-438f-80e8-901e59d54700", new DateTime(2024, 8, 25, 13, 46, 52, 381, DateTimeKind.Utc).AddTicks(7677), "AQAAAAIAAYagAAAAEO0yvwFG6Ayy23HGofBO2GwgKn2oH3Z97LkF+qoiNYTwehC/nJsxIykM1nyNB7Sf/Q==", "7915a98b-d6a7-4e9f-9f7b-a9f72df76cce" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 46, 51, 830, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 46, 51, 830, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 46, 51, 830, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 46, 51, 830, DateTimeKind.Local).AddTicks(6867));
        }
    }
}
