using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KabobwichesAsp.Migrations
{
    public partial class sidesanddrinksmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Kabobwiches",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drinks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sides",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sides_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kabobwiches_OrderId",
                table: "Kabobwiches",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_OrderId",
                table: "Drinks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Sides_OrderId",
                table: "Sides",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kabobwiches_Orders_OrderId",
                table: "Kabobwiches",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kabobwiches_Orders_OrderId",
                table: "Kabobwiches");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Sides");

            migrationBuilder.DropIndex(
                name: "IX_Kabobwiches_OrderId",
                table: "Kabobwiches");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Kabobwiches");
        }
    }
}
