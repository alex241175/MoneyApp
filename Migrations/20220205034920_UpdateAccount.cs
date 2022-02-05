using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoneyApp.Migrations
{
    public partial class UpdateAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ToBaseExchangeRate",
                table: "Accounts",
                type: "REAL",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToBaseExchangeRate",
                table: "Accounts");
        }
    }
}
