using Microsoft.EntityFrameworkCore.Migrations;

namespace CtecMateriais.Migrations
{
    public partial class MaterialForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Material_MaterialIdMaterial",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_MaterialIdMaterial",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "MaterialIdMaterial",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_MaterialId",
                table: "Usuario",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Material_MaterialId",
                table: "Usuario",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "IdMaterial",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Material_MaterialId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_MaterialId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "MaterialIdMaterial",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_MaterialIdMaterial",
                table: "Usuario",
                column: "MaterialIdMaterial");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Material_MaterialIdMaterial",
                table: "Usuario",
                column: "MaterialIdMaterial",
                principalTable: "Material",
                principalColumn: "IdMaterial",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
