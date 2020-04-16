using Microsoft.EntityFrameworkCore.Migrations;

namespace KabobwichesAsp.Migrations
{
    public partial class version11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CardNum",
                table: "PaymentInfos",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CardNum",
                table: "PaymentInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
