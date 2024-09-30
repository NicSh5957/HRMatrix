using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMatrix.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalCompetences",
                table: "UserProfiles",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalSkills",
                table: "UserProfiles",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserProfileId",
                table: "Languages",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae2c6bab-f702-4ef8-a2b1-f69cd4a70ebe", "AQAAAAIAAYagAAAAEECI7+wX3C8w3NvcM6YO9gVqgshMRMOxxCZw1lX9XJTcoaAhz5pgwacQk7UN709O2A==", "21191e95-9a28-4cc6-a437-b540cd13a611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81bca07b-bc7b-4fe3-8405-48ba989c7204", "AQAAAAIAAYagAAAAEKVCyF2r9cQNald5WrIq6kBi1VZ8fT1CpgFFpAHQisHf5ZuNCq5CAOdCDw6TCNS7RQ==", "7853fc68-2cb9-4d3a-969f-e2a1429f17ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1d24371-15ac-43d1-a652-ca3bf5d85646", "AQAAAAIAAYagAAAAEOLgkOYxWDfRkkbdM/yAhBch7WZcjQogugKVRW5Ugi6hBKOKZ5UGNTpnYISio1TXkw==", "62be930e-c28c-4faf-bde5-2060721ba3ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c46de2e-666d-4c8d-8e0c-3b63285b884e", "AQAAAAIAAYagAAAAECfkqBOajwe7ZjhkupNk4cbGvNBprkIOknOgaWe7GJhi5nuTvZOnJsHcOXUFi7NhsQ==", "980c3233-3321-454c-a85d-06e404cf1abe" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserProfileId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_UserProfileId",
                table: "Languages",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_UserProfiles_UserProfileId",
                table: "Languages",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_UserProfiles_UserProfileId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_UserProfileId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "AdditionalCompetences",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "AdditionalSkills",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "Languages");

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
        }
    }
}
