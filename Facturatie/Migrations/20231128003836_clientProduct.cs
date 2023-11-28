using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Facturatie.Migrations
{
    /// <inheritdoc />
    public partial class clientProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Invoice_InvoiceID",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "InvoiceID",
                table: "Product",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_InvoiceID",
                table: "Product",
                newName: "IX_Product_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Client_ClientId",
                table: "Product",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Client_ClientId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Product",
                newName: "InvoiceID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ClientId",
                table: "Product",
                newName: "IX_Product_InvoiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Invoice_InvoiceID",
                table: "Product",
                column: "InvoiceID",
                principalTable: "Invoice",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
