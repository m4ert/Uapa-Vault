using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asignacion.TrabajoFinal.Database.Migraciones
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    CodigoProducto = table.Column<int>(type: "int", nullable: false),
                    DescripcionProducto = table.Column<string>(type: "nvarchar(35)", nullable: false),
                    PrecioProducto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostoProducto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExistenciaProducto = table.Column<int>(type: "int", nullable: false),
                    EstatusProducto = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto", x => x.CodigoProducto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "producto");
        }
    }
}
