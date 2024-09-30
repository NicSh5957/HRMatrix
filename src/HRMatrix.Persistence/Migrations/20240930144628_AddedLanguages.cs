using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMatrix.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedLanguages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8eef28b-0875-445e-ba6d-5fd5a28b803c", "AQAAAAIAAYagAAAAEKtMc1U+m3FKkZ5RNIYGqkUtg2y6Dlw0SFxpbtEt5Wbjb9//qIrBxy0w40hWLEmaew==", "fe0428ec-8e0a-4453-a770-d6af03cd1c5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ddfaaaf-5478-4d59-8d6c-e1862db85963", "AQAAAAIAAYagAAAAEIEiJT4lUV0eD9q3VCQF3b4lPb034XbPojtBHCwFX1gLL4JMwcGH/8O+p09WgV5Ayw==", "5308bff5-effb-4e0d-b005-0859043845f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e77c11a-dc8d-4dc6-83f7-027cb011598d", "AQAAAAIAAYagAAAAEJB/Vm7HoXIU2EzeK/BvAcC2I0pvuY9qOYjewmmKrzLB8Noe8O+T2VD3Bg0XjsnQjA==", "375b045f-20aa-4156-bdc3-14ca0fbfe84c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67b7eb52-f0f7-4e86-85a2-f3d03f3077b2", "AQAAAAIAAYagAAAAEJHfUH61jlwCuBadGQvN3n2X+WsHpJwaid9lX4V75+mkouV3XgCt+9x0UWWncbS0PA==", "5f9cd6eb-dc04-403d-ba46-37858f4fe495" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Английский" },
                    { 2, "Турецкий" },
                    { 3, "Немецкий" },
                    { 4, "Китайский" }
                });

            migrationBuilder.InsertData(
                table: "LanguageTranslations",
                columns: new[] { "Id", "LanguageCode", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 1, "en-US", 1, "English" },
                    { 2, "ru-RU", 1, "Английский" },
                    { 3, "en-US", 2, "Turkish" },
                    { 4, "ru-RU", 2, "Турецкий" },
                    { 5, "en-US", 3, "German" },
                    { 6, "ru-RU", 3, "Немецкий" },
                    { 7, "en-US", 4, "Chinese" },
                    { 8, "ru-RU", 4, "Китайский" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTranslations_LanguageId",
                table: "LanguageTranslations",
                column: "LanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageTranslations");

            migrationBuilder.DropTable(
                name: "Languages");

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
        }
    }
}
