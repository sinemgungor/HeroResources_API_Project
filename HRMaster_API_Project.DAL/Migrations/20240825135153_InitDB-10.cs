using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e7423cba-344b-4a22-9ae9-60ac841b8afc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "313d1bdd-0d8a-409e-916c-7d33f3f1d006");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "9533dd53-8d5f-422a-9ad4-6875b6955324");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e666d23-2da7-4ee6-a281-a551ed9421d2", new DateTime(2024, 8, 25, 13, 51, 52, 259, DateTimeKind.Utc).AddTicks(9887), "AQAAAAIAAYagAAAAEEEYNPYORbRqwKvNGwsG3j7Aq6JQSq0sIQ+PazRdmlslA+ROol0LykJSZVuxWDB6+w==", "cbe50fda-7294-49f0-ae9f-77be669264f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "831d8f4a-48f1-41c4-9eee-8a9f87658a3f", new DateTime(2024, 8, 25, 13, 51, 52, 328, DateTimeKind.Utc).AddTicks(6529), "AQAAAAIAAYagAAAAEFtb6yUR1GpE+lnh9FdmCMJJjGORzqYeLHLWglHuIEB9IdyCzX5iFRuRXy2i/GbBJw==", "4b1dbf86-db23-4bc0-9b6a-c6777d605507" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fabdfbd-6dfb-41cd-9acb-f1cc599e3b29", new DateTime(2024, 8, 25, 13, 51, 52, 401, DateTimeKind.Utc).AddTicks(6021), "AQAAAAIAAYagAAAAEHvuq8qAHf77vfivK4HxpAoNQXbyVPLx5wd+P0P/czOe6xetiRceXLgiSvrfQpfgfw==", "5dbae324-622d-4550-885e-a53ea6c8e472" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da1ba44b-11a7-4dfa-98ec-8a9ee6a3cb3d", new DateTime(2024, 8, 25, 13, 51, 52, 477, DateTimeKind.Utc).AddTicks(280), "AQAAAAIAAYagAAAAEGjsXiLxsmyP7FnCJYTz6qA01EiN4DpC0hCoB1mOz+vFwHZag9GvMqBX4ycshjPErQ==", "5d47b98e-b000-4987-a2f4-97c0fbbe9c4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "370656d3-0174-44e8-bbdf-0956e9e70a24", new DateTime(2024, 8, 25, 13, 51, 52, 556, DateTimeKind.Utc).AddTicks(515), "AQAAAAIAAYagAAAAEBubfUXhB/Gql3fM9sbPk7RpbalPeMX2So+tRBHVMySc1shAV/vGwKNYY61ilXF7Gw==", "a0fcbca9-8a19-41d0-99d7-be2426589525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbf4f262-6f2e-4add-ae33-f0fd8293a481", new DateTime(2024, 8, 25, 13, 51, 52, 644, DateTimeKind.Utc).AddTicks(4015), "AQAAAAIAAYagAAAAEKSuqUoVP6U5hBVVqQLFdm9TsFEYTuR08niSoIO4SUN2ab66xrQb8/+4MDk+6CSSRw==", "0d2aea6c-12fd-45d3-b230-267ea7fe922e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e105bda8-efc2-422d-be09-021ed1527f43", new DateTime(2024, 8, 25, 13, 51, 52, 719, DateTimeKind.Utc).AddTicks(2047), "AQAAAAIAAYagAAAAEIz1qJScLwraUoAa/GyLuJpA97vrTK4qKD2H0eoIy+7lri9+r8+lLT8zBwKZwBfuhA==", "a780f350-3bc0-422d-8617-49e87efb1dfe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf888ebb-f408-4aee-b799-02f0ae9788c6", new DateTime(2024, 8, 25, 13, 51, 52, 795, DateTimeKind.Utc).AddTicks(8432), "AQAAAAIAAYagAAAAEHkLJ7sPtepjqh2+gRnzP7laC+LTXckegLf0U/DjxB0/Wj9ssKLQGKv0ssORhaZZxQ==", "41981f88-344e-4b9e-a64f-24da21b7d5dc" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 51, 52, 253, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 51, 52, 253, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 51, 52, 253, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 25, 16, 51, 52, 253, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "CompanyID", "CreationDate", "DepartmentName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları", 0, null },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finans", 0, null },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pazarlama", 0, null },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji", 0, null },
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", 0, null },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mühendislik", 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 6);

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
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b80685a8-d68c-4c66-8213-4753fe3352ad", new DateTime(2024, 8, 25, 13, 49, 17, 840, DateTimeKind.Utc).AddTicks(9075), "AQAAAAIAAYagAAAAEE8cyshVTzFfUmxoME90QGcwKi02iH8OJX49K2vW3NHWxX0wU0yMxYIB4DDjv8GUmw==", "1a42d0ec-24fb-41a8-97b2-1d012d7cf282" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acc86d50-2f6e-48b4-85a0-a4e36061c404", new DateTime(2024, 8, 25, 13, 49, 17, 930, DateTimeKind.Utc).AddTicks(6128), "AQAAAAIAAYagAAAAEKjSj3bWlGEven3CBBkMDV0FjM/8qpBwCNnh+qS0nw3FpiBZPOk+mVucwz2j8m1xTQ==", "5dee77dc-6000-44d9-b381-1f9e66adfe15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6883ccd-0793-4060-afa6-3a3b1c136e96", new DateTime(2024, 8, 25, 13, 49, 18, 1, DateTimeKind.Utc).AddTicks(1753), "AQAAAAIAAYagAAAAEKx5ukMNdBUM8cb5h0U/tSJzpUb+WmOi5diycsvNB7HnrqxMOg9sYEPQeH5vxaq3lQ==", "0ed40309-7382-4ac5-a6d8-61edfb555b2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1dcf26e-cc61-4685-8fde-c506fe27c3fb", new DateTime(2024, 8, 25, 13, 49, 18, 93, DateTimeKind.Utc).AddTicks(1419), "AQAAAAIAAYagAAAAEOpAcAFZqVCtipsfJjrHNyjeq7YB/o4KHt54GX80mLq0VQi5EFcCozW8KjmbIWmYLA==", "c08be30e-1f02-4e24-9387-f18eefff6692" });

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
    }
}
