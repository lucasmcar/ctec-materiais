using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CtecMateriais.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MaterialIdMaterial = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Material_MaterialIdMaterial",
                        column: x => x.MaterialIdMaterial,
                        principalTable: "Material",
                        principalColumn: "IdMaterial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroRetirada",
                columns: table => new
                {
                    IdRetirada = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Retirada = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UsuarioIdUsuario = table.Column<int>(nullable: true),
                    TotalRetiradas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroRetirada", x => x.IdRetirada);
                    table.ForeignKey(
                        name: "FK_RegistroRetirada_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistroRetirada_UsuarioIdUsuario",
                table: "RegistroRetirada",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_MaterialIdMaterial",
                table: "Usuario",
                column: "MaterialIdMaterial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroRetirada");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
