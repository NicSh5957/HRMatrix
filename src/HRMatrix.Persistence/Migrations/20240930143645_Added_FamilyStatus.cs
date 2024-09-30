using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMatrix.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Added_FamilyStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperience_UserProfiles_UserProfileId",
                table: "WorkExperience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkExperience",
                table: "WorkExperience");

            migrationBuilder.RenameTable(
                name: "WorkExperience",
                newName: "WorkExperiences");

            migrationBuilder.RenameIndex(
                name: "IX_WorkExperience_UserProfileId",
                table: "WorkExperiences",
                newName: "IX_WorkExperiences_UserProfileId");

            migrationBuilder.AddColumn<int>(
                name: "MaritalStatusId",
                table: "UserProfiles",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkExperiences",
                table: "WorkExperiences",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MaritalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FamilyStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserProfileId = table.Column<int>(type: "int", nullable: false),
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false),
                    TimesMarried = table.Column<int>(type: "int", nullable: false),
                    MarriagePeriods = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyStatuses_MaritalStatuses_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyStatuses_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatusTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatusTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaritalStatusTranslations_MaritalStatuses_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33b5749c-e226-43a8-95b7-ba67a73d40b6", "AQAAAAIAAYagAAAAENt05tlDRfT6HSDRDP81xW93PLU06vhOn+Yxya8Mp1u0MLBEsclcB0REh37Qcx8JyQ==", "28ea83b7-e310-4348-bd8c-35ea75c61193" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47bc270f-e5a1-47b6-96ec-53d1d587d544", "AQAAAAIAAYagAAAAEOig2zt88zNKbBVwbgnsGK+Dl7Morhd4kY8rZJKgNmpRoRqqxfR9mk8KPObkcqJToQ==", "f067426e-61d5-4bd3-8342-a0bfdedce713" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04b09017-ee30-4d9b-9427-9ddb6cc76c9e", "AQAAAAIAAYagAAAAENSOY6oCa8xV0jrrz3sEXcfngZzUEIbt7wAdHji53nrotqAbsTQS8eelbgjinecbOg==", "d525ce6e-edc3-47f0-974c-bf4a94742f19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a5e2e4f-db2a-4f14-9a7c-62cdca55533a", "AQAAAAIAAYagAAAAEFvIKAf7wxyi7oE83B1YOHtwQ1jvYey9jom8c40mbY4XH3ZYtQecOlWO8tF5pzQkxQ==", "2de41525-cd4f-41a8-ba28-ff7254ceab3e" });

            migrationBuilder.InsertData(
                table: "MaritalStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Женат/Замужем" },
                    { 2, "Холост/Не замужем" },
                    { 3, "Разведен(а)" }
                });

            migrationBuilder.InsertData(
                table: "MaritalStatusTranslations",
                columns: new[] { "Id", "LanguageCode", "MaritalStatusId", "Name" },
                values: new object[,]
                {
                    { 1, "en-US", 1, "Married" },
                    { 2, "ky-KG", 1, "Күйөөм (Замужем)" },
                    { 3, "en-US", 2, "Single" },
                    { 4, "ky-KG", 2, "Бекар" },
                    { 5, "en-US", 3, "Divorced" },
                    { 6, "ky-KG", 3, "Ажыратылган" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_MaritalStatusId",
                table: "UserProfiles",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyStatuses_MaritalStatusId",
                table: "FamilyStatuses",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyStatuses_UserProfileId",
                table: "FamilyStatuses",
                column: "UserProfileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaritalStatusTranslations_MaritalStatusId",
                table: "MaritalStatusTranslations",
                column: "MaritalStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_MaritalStatuses_MaritalStatusId",
                table: "UserProfiles",
                column: "MaritalStatusId",
                principalTable: "MaritalStatuses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_UserProfiles_UserProfileId",
                table: "WorkExperiences",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_MaritalStatuses_MaritalStatusId",
                table: "UserProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_UserProfiles_UserProfileId",
                table: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "FamilyStatuses");

            migrationBuilder.DropTable(
                name: "MaritalStatusTranslations");

            migrationBuilder.DropTable(
                name: "MaritalStatuses");

            migrationBuilder.DropIndex(
                name: "IX_UserProfiles_MaritalStatusId",
                table: "UserProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkExperiences",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "MaritalStatusId",
                table: "UserProfiles");

            migrationBuilder.RenameTable(
                name: "WorkExperiences",
                newName: "WorkExperience");

            migrationBuilder.RenameIndex(
                name: "IX_WorkExperiences_UserProfileId",
                table: "WorkExperience",
                newName: "IX_WorkExperience_UserProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkExperience",
                table: "WorkExperience",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfcde115-ea04-4f1d-832d-c8b17cc43810", "AQAAAAIAAYagAAAAEN2tmwARrXhqFXYXMluBZWbr1cUgIIOQwVkJHckzsFfZayyL8N3Kspre6gxwwCsMvA==", "91a8099b-649d-40eb-a782-3b6c759902af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcc24f7c-c378-47e0-bd58-338bb988e4c1", "AQAAAAIAAYagAAAAEJ9O61uWrO/m4Ma9rjTM1sYFQfmnOJbw9O4gCmo1zb4vleLWehdnxgxQ/fi4XrEIeQ==", "62857d07-9441-4d5d-b2a1-b7652a922dbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27e7cd76-301e-46ad-a465-af490a2c8554", "AQAAAAIAAYagAAAAEOm+A2xc9fuAoI8mF17G96TIE9D+2JrjpdgSKKpBKkeBW7+HnjSVg24KhZ6+HeJ7Iw==", "fb04ead6-e90c-4a3a-ba47-7d3e2d20d768" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "315beb1e-0f58-4d59-8f2c-1b985259b529", "AQAAAAIAAYagAAAAEGOVG/h8XSogXn/lIc3Vgx5y/lZETNN2G+m3vjwgtCg5t6nwQtEIhkOirmE2RxjC3A==", "b4fddf10-8ab6-4257-af3b-9ff589fad499" });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperience_UserProfiles_UserProfileId",
                table: "WorkExperience",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
