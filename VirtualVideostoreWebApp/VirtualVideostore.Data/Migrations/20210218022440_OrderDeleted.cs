using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualVideostore.Data.Migrations
{
    public partial class OrderDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Orders_orderId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Movies_orderId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "orderId",
                table: "Movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "orderId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wishlistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_orderId",
                table: "Movies",
                column: "orderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Orders_orderId",
                table: "Movies",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "orderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
