using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class mudartabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mesas",
                table: "Mesas");

            migrationBuilder.RenameTable(
                name: "Mesas",
                newName: "Carros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros",
                table: "Carros",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros",
                table: "Carros");

            migrationBuilder.RenameTable(
                name: "Carros",
                newName: "Mesas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mesas",
                table: "Mesas",
                column: "Id");
        }
    }
}
