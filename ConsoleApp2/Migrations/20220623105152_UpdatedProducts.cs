using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    public partial class UpdatedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Items_ProductID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProductID",
                table: "Items",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Cnic",
                table: "Customers",
                column: "Cnic",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Items_ProductID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Cnic",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProductID",
                table: "Items",
                column: "ProductID",
                unique: true);
        }
    }
}
