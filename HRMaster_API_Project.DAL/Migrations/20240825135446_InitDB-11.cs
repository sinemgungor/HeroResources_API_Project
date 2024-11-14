using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "CompanyID", "CreationDate", "DepartmentName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları", 0, null },
                    { 8, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", 0, null },
                    { 9, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mühendislik", 0, null },
                    { 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ar-Ge", 0, null },
                    { 11, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pazarlama", 0, null },
                    { 12, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lojistik", 0, null },
                    { 13, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lojistik", 0, null },
                    { 14, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları", 0, null },
                    { 15, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finans", 0, null },
                    { 16, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji", 0, null },
                    { 17, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pazarlama", 0, null },
                    { 18, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", 0, null },
                    { 19, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji", 0, null },
                    { 20, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", 0, null },
                    { 21, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pazarlama", 0, null },
                    { 22, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ar-Ge", 0, null },
                    { 23, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mühendislik", 0, null },
                    { 24, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lojistik", 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 24);

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
        }
    }
}
