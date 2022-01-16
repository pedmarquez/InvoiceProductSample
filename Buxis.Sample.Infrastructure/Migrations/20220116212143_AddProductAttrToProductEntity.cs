using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buxis.Sample.Infrastructure.Migrations
{
    public partial class AddProductAttrToProductEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductProductAttribute",
                columns: table => new
                {
                    ProductAttributesId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductAttribute", x => new { x.ProductAttributesId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductProductAttribute_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductAttribute_ProductAttribute_ProductAttributesId",
                        column: x => x.ProductAttributesId,
                        principalTable: "ProductAttribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductAttribute_ProductId",
                table: "ProductProductAttribute",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProductAttribute");
        }
    }
}
