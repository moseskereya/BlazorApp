using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp4.Server.Migrations
{
    public partial class AddingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Email", "Experience", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "myemail@gmail.com", 3m, "Moses", "Lazaro" },
                    { 2, "scott@gmail.com", 40m, "Scott", "Cate" },
                    { 3, "Dev@gmai.com", 10m, "Dev", "Edd" },
                    { 4, "travesy@gmail.com", 20m, "Brad", "Travesy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
