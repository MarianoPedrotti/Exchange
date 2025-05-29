using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exchange.Migrations
{
    /// <inheritdoc />
    public partial class CoreccionTransaccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cantidad",
                table: "Transacciones",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Transacciones");
        }
    }
}
