using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buxis.Sample.Infrastructure.Migrations
{
    public partial class AddPriceInvoiceItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "InvoiceItem",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "InvoiceItem");
        }
    }
}
