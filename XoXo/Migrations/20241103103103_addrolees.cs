using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XoXo.Migrations
{
    public partial class addrolees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19dee671-5655-447a-a8bb-a4eb9e8fc329", "3af1dda8-2990-49aa-b79f-ee258f8ddb8a", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f0de972-c770-42dc-b1c8-33490a7b6373", "f85d5710-ac74-4227-9ea3-267e84d11931", "Admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19dee671-5655-447a-a8bb-a4eb9e8fc329");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f0de972-c770-42dc-b1c8-33490a7b6373");
        }
    }
}
