using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMaster_API_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SecondSurname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PicturePath = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: true),
                    BirthState = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdentityNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: true),
                    TerminationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MarialStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    CEORelatedCompanyID = table.Column<int>(type: "int", nullable: true),
                    EmployeeRelatedCompanyID = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CompanyTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MersisNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TaxOfficeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TaxIdentificaitonNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CompanyPhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CompanyType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyField = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EstablishedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ContractStartingDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ContractEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CompanyInformation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CEOId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Companies_AspNetUsers_CEOId",
                        column: x => x.CEOId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    ManagerID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Departments_AspNetUsers_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departments_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "18d61ff3-e47e-404b-b2ce-b72b474539ae", "SuperAdmin", "SUPERADMIN" },
                    { 2, "97dc5810-aa52-4d39-a832-cce6bf722963", "Manager", "MANAGER" },
                    { 3, "37282ed8-4d30-4e48-963f-ad312374fd80", "DepartmentManager", "DEPARTMENTMANAGER" },
                    { 4, "5c43046d-0238-4295-bd1e-28f6aad92198", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthState", "BloodGroup", "CEORelatedCompanyID", "ConcurrencyStamp", "CreationDate", "DepartmentID", "Email", "EmailConfirmed", "EmployeeRelatedCompanyID", "Gender", "HireDate", "IdentityNumber", "Job", "LockoutEnabled", "LockoutEnd", "MarialStatus", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PicturePath", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Status", "Surname", "TerminationDate", "Title", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "Üsküdar", null, null, "BPositive", null, "23665298-d284-4937-bfe0-a49b36f87970", new DateTime(2024, 8, 15, 14, 37, 26, 32, DateTimeKind.Utc).AddTicks(314), null, "onurakpinarr95@gmail.com", true, null, "Male", null, null, null, false, null, "Single", "Onur", "ONURAKPINARR95@GMAIL.COM", "ONURAKPINARR95@GMAIL.COM", "AQAAAAIAAYagAAAAEGNg4qi1D5zJ0rzzTHir+L+ycUqLT5XVA2jUkIBvWwJUC+/CNa4xSk3CZFADaN8hgQ==", "+905555555555", false, null, null, null, null, "eaec20a4-71c6-4c08-8955-940b9f63b6e5", 1, "Akpınar", null, null, false, null, "onurakpinarr95@gmail.com" },
                    { 2, 0, "Küçükyalı", null, null, "APositive", null, "0282b0be-d518-41d0-a911-40626455eec0", new DateTime(2024, 8, 15, 14, 37, 26, 105, DateTimeKind.Utc).AddTicks(8517), null, "sinemgngr@outlook.com", true, null, "Female", null, null, null, false, null, "Single", "Sinem", "SINEMGNGR@OUTLOOK.COM", "SINEMGNGR@OUTLOOK.COM", "AQAAAAIAAYagAAAAEFM9oyGcWUovwGwvcKuFqcgOmMZe/nWgS22zWTdE3wGBXJ5Btun7lUQ2lFAc9frfDg==", "+90544444444", false, null, null, null, null, "fc2de279-a94f-4148-9c3e-daf5d7fc5e39", 1, "Güngör", null, null, false, null, "sinemgngr@outlook.com" },
                    { 3, 0, "Edirne", null, null, "OPositive", null, "5e0a1018-db38-40c1-a49c-488e35228f1d", new DateTime(2024, 8, 15, 14, 37, 26, 175, DateTimeKind.Utc).AddTicks(9553), null, "recepoztuna@hotmail.com", true, null, "Male", null, null, null, false, null, "Single", "Recep", "RECEPOZTUNA@HOTMAIL.COM", "RECEPOZTUNA@HOTMAIL.COM", "AQAAAAIAAYagAAAAEL1WgxBpZETm8fhMhCkCyR2S7JkguFOH4b5r+8iG5FHZcT73W9fmFkda8I4SnrQfTQ==", "+905333333333", false, null, null, null, null, "f891954b-4dc7-4744-9212-6844be6f74fe", 1, "Öztuna", null, null, false, null, "recepoztuna@hotmail.com" },
                    { 4, 0, "Zeytinburnu", null, null, "ABPositive", null, "c8fc8374-52c0-4f4e-917d-848ed36e2a5c", new DateTime(2024, 8, 15, 14, 37, 26, 245, DateTimeKind.Utc).AddTicks(5407), null, "ozercemre1@gmail.com", true, null, "Male", null, null, null, false, null, "Single", "Cemre", "RECEPOZTUNA@HOTMAIL.COM", "OZERCEMRE1@GMAIL.COM", "AQAAAAIAAYagAAAAEFLIbQjaCqu/3EYpBGoEVtTU5CrF/9dkDQViI0kp6zwyoMMiLvgIKBpu36xbKGa3Kg==", "+905311111111", false, null, null, null, null, "4c366271-a609-40f9-ac62-e12dfa7c6d4e", 1, "Admin", null, null, false, null, "ozercemre1@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "ID", "CEOId", "CompanyAddress", "CompanyEmail", "CompanyField", "CompanyInformation", "CompanyName", "CompanyPhoneNumber", "CompanyTitle", "CompanyType", "CompanyWebsite", "ContractEndDate", "ContractStartingDate", "CreationDate", "EstablishedDate", "LogoPath", "MersisNumber", "Status", "TaxIdentificaitonNumber", "TaxOfficeName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "123 Innovation Drive", "contact@techinnovations.com", "Technology", "Leading tech company specializing in innovative solutions.", "Tech Innovations", "555-1234", "Tech Innovations Bilişim ve Teknoloji Şirketi", "SoleProprietorship", "www.techinnovations.com", new DateOnly(1, 1, 1), new DateOnly(2020, 3, 30), new DateTime(2024, 8, 15, 17, 37, 25, 974, DateTimeKind.Local).AddTicks(3395), new DateOnly(2001, 4, 23), "/images/logos/tech_innovations.png", "1234567890", 0, "TI123456", "Downtown Tax Office", null },
                    { 2, null, "456 Green Road", "info@greenenergy.com", "Energy", "Providing renewable energy solutions worldwide.", "Green Energy Solutions", "555-5678", "Green Energy Solutions AŞ.", "JointStockCompany", "www.greenenergy.com", new DateOnly(1, 1, 1), new DateOnly(2020, 3, 30), new DateTime(2024, 8, 15, 17, 37, 25, 974, DateTimeKind.Local).AddTicks(3450), new DateOnly(2010, 7, 15), "/images/logos/greenenergy.jpeg", "0987654321", 0, "TI654321", "Uptown Tax Office", null },
                    { 3, null, "789 Wellness Ave", "support@healthwellness.com", "Healthcare", "Committed to providing top health and wellness services.", "Health & Wellness", "555-7890", "Health & Wellness Sağlık ve Güzellik Merkezi LTD.ŞTİ.", "LimitedCompany", "www.healthwellness.com", new DateOnly(1, 1, 1), new DateOnly(2020, 3, 30), new DateTime(2024, 8, 15, 17, 37, 25, 974, DateTimeKind.Local).AddTicks(3456), new DateOnly(2015, 3, 30), "/images/logos/healthandwellness.jpeg", "1122334455", 0, "TI112233", "City Tax Office", null },
                    { 4, null, "101 Education Blvd", "admissions@edufuture.com", "Education", "Innovative education for the future.", "EduFuture Academy", "555-1011", "EduFuture Eğitim Merkezi LTD.ŞTİ.", "LimitedCompany", "www.edufuture.com", new DateOnly(1, 1, 1), new DateOnly(2020, 3, 30), new DateTime(2024, 8, 15, 17, 37, 25, 974, DateTimeKind.Local).AddTicks(3460), new DateOnly(2020, 1, 10), "/images/logos/edufuture.jpeg", "5566778899", 0, "TI556677", "Suburb Tax Office", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentID",
                table: "AspNetUsers",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployeeRelatedCompanyID",
                table: "AspNetUsers",
                column: "EmployeeRelatedCompanyID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CEOId",
                table: "Companies",
                column: "CEOId",
                unique: true,
                filter: "[CEOId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyID",
                table: "Departments",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments",
                column: "ManagerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_EmployeeRelatedCompanyID",
                table: "AspNetUsers",
                column: "EmployeeRelatedCompanyID",
                principalTable: "Companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentID",
                table: "AspNetUsers",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AspNetUsers_CEOId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_AspNetUsers_ManagerID",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
