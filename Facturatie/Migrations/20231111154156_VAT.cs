using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Facturatie.Migrations
{
    /// <inheritdoc />
    public partial class VAT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "VAT",
                table: "Invoice",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VAT",
                table: "Invoice");
        }
    }
}
