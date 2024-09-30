using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMatrix.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Added_WOrk_Experience : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkExperience",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserProfileId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Achievements = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExperience_UserProfiles_UserProfileId",
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

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_UserProfileId",
                table: "WorkExperience",
                column: "UserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkExperience");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c64c5600-7216-44b0-b1e9-494824d60c23", "AQAAAAIAAYagAAAAEAzot7J+JMwfGj4HNc/wrYnlQSRVHNZG+/ZUuwSZrwu/POirFKWvMwTPaz63jtDPGw==", "d478eefb-0cb2-4629-a118-7ddf46e899dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3fb9e21-628c-48a2-9b27-4f941ec2e5f4", "AQAAAAIAAYagAAAAEHhsEjLY/MKovq1xyOivkLk0kslgqSDFVev9FQhaGJKFngHM1urUjfB3cgoRsz9h3w==", "6b852209-ba3c-470a-9ed3-417c52df8bfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e208db1-d26e-4733-9c4a-e6ec99860b1b", "AQAAAAIAAYagAAAAEP1JsPS8x/D6W5fkK5+rZGXk/VWO3eTxJrGky3BYUUc0ecIK0vHQlkZpfcEj7gi8Rw==", "6225dd77-c2f7-4f0c-bec0-1e23114b1d93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d966b78a-1816-4f40-96e3-3ace51766e83", "AQAAAAIAAYagAAAAEGU3NT0x43BrTFZ+KEoP/aUMLRC39ooUp6+XbMNCvSrBIIpC9z5LuCq2dgfdBsln6g==", "50c95f87-5f37-4a83-934d-2082bc74f717" });
        }
    }
}
