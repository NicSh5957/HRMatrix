using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMatrix.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevelTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EducationLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevelTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationLevelTranslations_EducationLevels_EducationLevelId",
                        column: x => x.EducationLevelId,
                        principalTable: "EducationLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEducations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserProfileId = table.Column<int>(type: "int", nullable: false),
                    EducationLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEducations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEducations_EducationLevels_EducationLevelId",
                        column: x => x.EducationLevelId,
                        principalTable: "EducationLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEducations_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19c853bd-b554-4cb1-8a70-e6d52ec559fc", "AQAAAAIAAYagAAAAEIyE161R5YTyxw1pyC5DKQ+XrqFVvOSgW4/P4272xpB7UGnhe1IXe9ipEP2c1VMt6Q==", "3e0fc776-fc33-4395-b65d-a3f13332e801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "287ed7cd-42ac-4db0-8a44-d46d6e8bde89", "AQAAAAIAAYagAAAAEJ1cs3Lxz1FXaoMbR2uRyIhxfI8/uSPSVWvbGI+OoBZ7Y0bFvMGlfdwqOJb38hoeZw==", "4356a635-ed0a-4383-9d9e-c1d62136fe51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13b59d7e-5400-4b8c-af84-d47d269d6dcf", "AQAAAAIAAYagAAAAEJe0pIGhiGy/cyRw0wZUmLVVwRbQaV+f8yOAv/VZhBP4PBwl5uhSXJfeDHKrtb4cDw==", "d0014b30-de17-41b5-8bea-71259594f749" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfefe5b8-57a0-43be-8f49-5bc82219054a", "AQAAAAIAAYagAAAAEBkvGEkqmnaQpZHg2XPX3KziJwhaPmdXWQGYY1hOzqWy7wium7YDbMgjnkzVoUP90Q==", "5513ad60-4c36-49db-bff2-7c0dc245de14" });

            migrationBuilder.InsertData(
                table: "EducationLevels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Высшее законченное (Магистр)" },
                    { 2, "Среднее специальное / профессиональное" },
                    { 3, "Кандидат наук" },
                    { 4, "Доктор наук" },
                    { 5, "Доцент" }
                });

            migrationBuilder.InsertData(
                table: "EducationLevelTranslations",
                columns: new[] { "Id", "EducationLevelId", "LanguageCode", "Name" },
                values: new object[,]
                {
                    { 1, 1, "ru-RU", "Высшее законченное (Магистр)" },
                    { 2, 1, "en-US", "Higher Education (Master)" },
                    { 3, 1, "ky-KG", "Жогорку билим (Магистр)" },
                    { 4, 2, "ru-RU", "Среднее специальное / профессиональное" },
                    { 5, 2, "en-US", "Specialized Secondary / Professional" },
                    { 6, 2, "ky-KG", "Орточо кесиптик билим" },
                    { 7, 3, "ru-RU", "Кандидат наук" },
                    { 8, 3, "en-US", "Candidate of Sciences" },
                    { 9, 3, "ky-KG", "Илим кандидаты" },
                    { 10, 4, "ru-RU", "Доктор наук" },
                    { 11, 4, "en-US", "Doctor of Sciences" },
                    { 12, 4, "ky-KG", "Илим доктору" },
                    { 13, 5, "ru-RU", "Доцент" },
                    { 14, 5, "en-US", "Associate Professor" },
                    { 15, 5, "ky-KG", "Ассистент профессор" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationLevelTranslations_EducationLevelId",
                table: "EducationLevelTranslations",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEducations_EducationLevelId",
                table: "UserEducations",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEducations_UserProfileId",
                table: "UserEducations",
                column: "UserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationLevelTranslations");

            migrationBuilder.DropTable(
                name: "UserEducations");

            migrationBuilder.DropTable(
                name: "EducationLevels");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b53e5a87-25b3-41af-8511-c10c5c291e43", "AQAAAAIAAYagAAAAECCqU1bS/uCIWKrpwW9g+nL0SC63rXnm+1UbUR7/J8jQ6V7hleaKmegQSoRR5KKG8A==", "91cd1886-ef38-4c8a-9870-abf420ce5d1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "708ab15d-404b-4b61-85d8-30e72a78ba8b", "AQAAAAIAAYagAAAAEFZr6KmFDE3Jdresql7YaoerXRPwv6CiuVfe1Pktj3OiwtY2sgtJAzyt7UGTkuoqiQ==", "12ee852e-1279-4d11-8324-39d468d3987f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "631511ff-7fe9-46cd-9c36-dec0432bc835", "AQAAAAIAAYagAAAAEIuZPvz6yXi9JGWFUJikZ5ibkQUv9yEM1Mtqd0wjT1ECVhOY548ph44cWusYd+Vtgw==", "f412ab00-6219-40a3-84dc-5099fba80afa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8483724-5933-41e5-b386-83ec294547b1", "AQAAAAIAAYagAAAAEFU7dvGeuYRdHwMGBTjlHOtBh+3YZ9XsWchi5IsGeFOD8Saq58M5tCeepxhkgvpyXA==", "70665583-abd0-40be-98ef-ed12c99b0988" });
        }
    }
}
