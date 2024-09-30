using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMatrix.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedQuantityToUserEducationConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "UserEducations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "UserEducations");

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
        }
    }
}
