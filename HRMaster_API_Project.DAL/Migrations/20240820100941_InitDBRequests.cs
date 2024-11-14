using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDBRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_AspNetUsers_ManagerID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ManagerID",
                table: "Departments");

            migrationBuilder.CreateTable(
                name: "AdvanceRequests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovalStatus = table.Column<int>(type: "int", nullable: false),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AdvanceType = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvanceRequests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AdvanceRequests_AspNetUsers_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseRequests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseType = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    ApprovalStatus = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseRequests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExpenseRequests_AspNetUsers_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveType = table.Column<int>(type: "int", nullable: false),
                    LeaveStartingDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LeaveEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LeaveDays = table.Column<double>(type: "float", nullable: false),
                    ApprovalStatus = table.Column<int>(type: "int", nullable: false),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_AspNetUsers_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2c44f0b0-6bd2-4afa-8399-49060aedadb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1bc18d95-81d0-423e-bc38-666c64b74f08");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "c0baafa7-9884-4f51-8117-d1ee4557adc7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b50216ff-5c96-4ba9-9a98-d5aaa9ba1524", new DateTime(2024, 8, 20, 10, 9, 41, 104, DateTimeKind.Utc).AddTicks(363), "AQAAAAIAAYagAAAAEDp2xPA9Wx7RjfagfKkKIwDcuwsY7smr8weuT2UYIfUTPw3HUm7FvDeJ2JIhi6mGIQ==", "5bd5b7f8-21ae-4b1e-8e2b-a30e4d88257c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5935b235-ac5c-4820-8856-42f41d138d36", new DateTime(2024, 8, 20, 10, 9, 41, 165, DateTimeKind.Utc).AddTicks(2139), "AQAAAAIAAYagAAAAEE25xEOnDREW/Fl9YlRaKp7bNgtyse0hmgalgukLqOcDrbQFnLLFOVLRZbGupGb89g==", "f02f7351-1830-4c92-9392-ca4dbf1c911f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f956a17-a701-411b-8a9a-b398f868c940", new DateTime(2024, 8, 20, 10, 9, 41, 223, DateTimeKind.Utc).AddTicks(1730), "AQAAAAIAAYagAAAAELLPbc1kSp8/k9uCg5fNvagbdLkJu6VpPr4T6175pq0kRcNLtv/TJWyIIuFT0Pn9pA==", "7c5f16f1-b2a6-47da-90d0-9014861fd441" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25de9f47-5b7a-4942-98b5-e1c1c0ae31ed", new DateTime(2024, 8, 20, 10, 9, 41, 280, DateTimeKind.Utc).AddTicks(7119), "OZERCEMRE1@GMAIL.COM", "AQAAAAIAAYagAAAAEEB/vPKW+2dkRrN7QwPaNJvd/06qRBYNPsWB39Rc3d2werJX2JVwXSKjLGZKgtc3pA==", "120c358a-8868-4436-99de-b3ce828854d4" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 13, 9, 41, 97, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 13, 9, 41, 97, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 13, 9, 41, 97, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 20, 13, 9, 41, 97, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceRequests_EmployeeID",
                table: "AdvanceRequests",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseRequests_EmployeeID",
                table: "ExpenseRequests",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeID",
                table: "LeaveRequests",
                column: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvanceRequests");

            migrationBuilder.DropTable(
                name: "ExpenseRequests");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.AddColumn<int>(
                name: "ManagerID",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "18d61ff3-e47e-404b-b2ce-b72b474539ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "97dc5810-aa52-4d39-a832-cce6bf722963");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "5c43046d-0238-4295-bd1e-28f6aad92198");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, "37282ed8-4d30-4e48-963f-ad312374fd80", "DepartmentManager", "DEPARTMENTMANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23665298-d284-4937-bfe0-a49b36f87970", new DateTime(2024, 8, 15, 14, 37, 26, 32, DateTimeKind.Utc).AddTicks(314), "AQAAAAIAAYagAAAAEGNg4qi1D5zJ0rzzTHir+L+ycUqLT5XVA2jUkIBvWwJUC+/CNa4xSk3CZFADaN8hgQ==", "eaec20a4-71c6-4c08-8955-940b9f63b6e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0282b0be-d518-41d0-a911-40626455eec0", new DateTime(2024, 8, 15, 14, 37, 26, 105, DateTimeKind.Utc).AddTicks(8517), "AQAAAAIAAYagAAAAEFM9oyGcWUovwGwvcKuFqcgOmMZe/nWgS22zWTdE3wGBXJ5Btun7lUQ2lFAc9frfDg==", "fc2de279-a94f-4148-9c3e-daf5d7fc5e39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e0a1018-db38-40c1-a49c-488e35228f1d", new DateTime(2024, 8, 15, 14, 37, 26, 175, DateTimeKind.Utc).AddTicks(9553), "AQAAAAIAAYagAAAAEL1WgxBpZETm8fhMhCkCyR2S7JkguFOH4b5r+8iG5FHZcT73W9fmFkda8I4SnrQfTQ==", "f891954b-4dc7-4744-9212-6844be6f74fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationDate", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8fc8374-52c0-4f4e-917d-848ed36e2a5c", new DateTime(2024, 8, 15, 14, 37, 26, 245, DateTimeKind.Utc).AddTicks(5407), "RECEPOZTUNA@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFLIbQjaCqu/3EYpBGoEVtTU5CrF/9dkDQViI0kp6zwyoMMiLvgIKBpu36xbKGa3Kg==", "4c366271-a609-40f9-ac62-e12dfa7c6d4e" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 8, 15, 17, 37, 25, 974, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 8, 15, 17, 37, 25, 974, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 8, 15, 17, 37, 25, 974, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 8, 15, 17, 37, 25, 974, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments",
                column: "ManagerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_AspNetUsers_ManagerID",
                table: "Departments",
                column: "ManagerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
