using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoShops.Migrations
{
    /// <inheritdoc />
    public partial class EditTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Product_Idproduct",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_IdCategory",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "IdCategory",
                table: "Product",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_IdCategory",
                table: "Product",
                newName: "IX_Product_CategoryID");

            migrationBuilder.RenameColumn(
                name: "Idproduct",
                table: "Cart",
                newName: "ProductIdProduct");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_Idproduct",
                table: "Cart",
                newName: "IX_Cart_ProductIdProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Product_ProductIdProduct",
                table: "Cart",
                column: "ProductIdProduct",
                principalTable: "Product",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Product_ProductIdProduct",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Product",
                newName: "IdCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                newName: "IX_Product_IdCategory");

            migrationBuilder.RenameColumn(
                name: "ProductIdProduct",
                table: "Cart",
                newName: "Idproduct");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_ProductIdProduct",
                table: "Cart",
                newName: "IX_Cart_Idproduct");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Product_Idproduct",
                table: "Cart",
                column: "Idproduct",
                principalTable: "Product",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_IdCategory",
                table: "Product",
                column: "IdCategory",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
