using Microsoft.EntityFrameworkCore.Migrations;

namespace KabobwichesAsp.Migrations
{
    public partial class publickabobwichfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bread",
                table: "Kabobwiches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Meat",
                table: "Kabobwiches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sauce",
                table: "Kabobwiches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Toppings",
                table: "Kabobwiches",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bread",
                table: "Kabobwiches");

            migrationBuilder.DropColumn(
                name: "Meat",
                table: "Kabobwiches");

            migrationBuilder.DropColumn(
                name: "Sauce",
                table: "Kabobwiches");

            migrationBuilder.DropColumn(
                name: "Toppings",
                table: "Kabobwiches");
        }
    }
}
