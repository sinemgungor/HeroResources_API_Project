using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e89f1ef2-b86c-4318-990b-be8381b0db5a", new DateTime(2024, 8, 25, 13, 46, 52, 129, DateTimeKind.Utc).AddTicks(9918), "AQAAAAIAAYagAAAAEHX7i61Eit5nu+PLkjtPMImGNL1myaeHWD9x6Rd8qZXaPikRsTATAlgY7pghlQiVLA==", "8dcede66-7159-4678-8f01-e73e35f954b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4df0c360-4d08-4199-b967-31b078dbadf7", new DateTime(2024, 8, 25, 13, 46, 52, 211, DateTimeKind.Utc).AddTicks(9628), "AQAAAAIAAYagAAAAELFYtN42Js1+lU+wZ1DrhYAUSWXHjJ3Ie6YVd9S7+qPxJUmRi+D6DacycNfmg7QDrg==", "044914df-ecfb-476b-8af4-9bf19a762608" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "996017dc-4214-4497-aa2a-7893b9b2dbd0", new DateTime(2024, 8, 25, 13, 46, 52, 285, DateTimeKind.Utc).AddTicks(3799), "AQAAAAIAAYagAAAAEJ4Le9Xlag5Cp/jULcUrfpJuUZOiLgl7xKMIKwxZSNHnHeOjGquYHwY2K8bEvOjL1g==", "bf47ae60-84fc-47b9-9b39-7aecf4131215" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eca9e664-524d-438f-80e8-901e59d54700", new DateTime(2024, 8, 25, 13, 46, 52, 381, DateTimeKind.Utc).AddTicks(7677), "AQAAAAIAAYagAAAAEO0yvwFG6Ayy23HGofBO2GwgKn2oH3Z97LkF+qoiNYTwehC/nJsxIykM1nyNB7Sf/Q==", "7915a98b-d6a7-4e9f-9f7b-a9f72df76cce" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CEOId", "CreationDate" },
                values: new object[] { 5, new DateTime(2024, 8, 25, 16, 46, 51, 830, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CEOId", "CreationDate" },
                values: new object[] { 6, new DateTime(2024, 8, 25, 16, 46, 51, 830, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CEOId", "CreationDate" },
                values: new object[] { 7, new DateTime(2024, 8, 25, 16, 46, 51, 830, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CEOId", "CreationDate" },
                values: new object[] { 8, new DateTime(2024, 8, 25, 16, 46, 51, 830, DateTimeKind.Local).AddTicks(6867) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23cc3064-fe58-4246-9479-39c0f25a60fc", new DateTime(2024, 8, 25, 13, 40, 5, 355, DateTimeKind.Utc).AddTicks(5642), "AQAAAAIAAYagAAAAEJcMGgAgFgTQUsehRg4v/i238oiuumatwal0glzIzYx1Xjrqcs8NCSLUQQeBD662uQ==", "d9f486b6-8fd7-4113-8698-990d8d38dd9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8134737b-c829-417d-b9a1-f42de5bc0f62", new DateTime(2024, 8, 25, 13, 40, 5, 446, DateTimeKind.Utc).AddTicks(5650), "AQAAAAIAAYagAAAAEADbJI/dDRM8/0LQPqdoVm0aPPWc49YZOwgrIzE6VdqaTURofF7qbk8ao9zCE8Ra6Q==", "04347f30-c210-412e-8cb4-fe991b72467c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "def574b8-e1be-4a43-9b9d-0f7c0340ec26", new DateTime(2024, 8, 25, 13, 40, 5, 523, DateTimeKind.Utc).AddTicks(3428), "AQAAAAIAAYagAAAAECWZWKyaih+SL/XLrF69sN5qct4jLqNwwoYiiKAooJPcUU8hT00n2ssckRUieexqww==", "fe86aa6b-d7e4-4e84-aca7-41013834f8a7" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CEOId", "CreationDate" },
                values: new object[] { null, new DateTime(2024, 8, 25, 16, 40, 4, 925, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CEOId", "CreationDate" },
                values: new object[] { null, new DateTime(2024, 8, 25, 16, 40, 4, 925, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CEOId", "CreationDate" },
                values: new object[] { null, new DateTime(2024, 8, 25, 16, 40, 4, 925, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CEOId", "CreationDate" },
                values: new object[] { null, new DateTime(2024, 8, 25, 16, 40, 4, 925, DateTimeKind.Local).AddTicks(7491) });
        }
    }
}
