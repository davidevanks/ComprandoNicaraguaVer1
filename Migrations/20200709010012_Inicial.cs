using Microsoft.EntityFrameworkCore.Migrations;

namespace ComprandoNicaragua.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatCategorias",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Estado = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatCategorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tiendas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCategoria = table.Column<long>(nullable: true),
                    CuentaInstagram = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    CuentaFacebook = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Telefono = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Aprobado = table.Column<bool>(nullable: true),
                    Estado = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tiendas_CatCategorias",
                        column: x => x.Id,
                        principalTable: "CatCategorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tiendas");

            migrationBuilder.DropTable(
                name: "CatCategorias");
        }
    }
}
