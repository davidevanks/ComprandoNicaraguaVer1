using Microsoft.EntityFrameworkCore.Migrations;

namespace ComprandoNicaragua.Migrations
{
    public partial class TiendasCuentaTwitter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CuentaTwitter",
                table: "Tiendas",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuentaTwitter",
                table: "Tiendas");
        }
    }
}
