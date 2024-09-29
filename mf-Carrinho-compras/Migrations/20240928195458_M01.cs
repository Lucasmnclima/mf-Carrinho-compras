using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_Carrinho_compras.Migrations
{
    /// <inheritdoc />
    public partial class M01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Venda",
                table: "Produtos",
                newName: "DataVenda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataVenda",
                table: "Produtos",
                newName: "Venda");
        }
    }
}
