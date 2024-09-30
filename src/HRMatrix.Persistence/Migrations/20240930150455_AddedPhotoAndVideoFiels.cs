using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMatrix.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhotoAndVideoFiels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePhotoPath",
                table: "UserProfiles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VideoPath",
                table: "UserProfiles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8e842c3-c9e7-4224-8412-a160fea84987", "AQAAAAIAAYagAAAAEOHYhQ3iERe7MagPAALysXWAVNrIO/T5zw2pdQrtFcOu4gV+bI38s7Oec/pFxApJwg==", "597da158-b987-4997-acda-2701b9473566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23f82e97-378b-44ee-b43a-9cb8f213b064", "AQAAAAIAAYagAAAAEHqsxqd9baFFkD6AlD0Cf/cEdJZSnwe2cJuBz+a0K+wDg3WyCGxZEYftNK0bSAYUpg==", "a12462b0-13cc-4a3c-a895-929d42d5b513" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61d7d215-77d1-49c5-962f-98f52a2d342b", "AQAAAAIAAYagAAAAEIZtXw0OLkom1CAE+RA4ZB7e759qnuElfUujNsFwjbwLGzElD6rnsRkkk6T1QPTlgg==", "5b7819a5-49a0-4baa-956c-7e1198a05aaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59d279f4-ab46-4abc-bea7-41b644bf9e47", "AQAAAAIAAYagAAAAEB7ov5GzgrhYfNfl+7TtQ8A2/c/9kVMloIC810tNvWPgUOFZ0MS/NqHj0+sdv2cGSw==", "36f1ab0a-3b5f-43f9-9cd7-87de186007b0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePhotoPath",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "VideoPath",
                table: "UserProfiles");

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
        }
    }
}
