using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PC2.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plantas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NroFactura = table.Column<int>(nullable: false),
                    moneda = table.Column<int>(nullable: false),
                    DiaEmision = table.Column<DateTime>(nullable: false),
                    DiaPago = table.Column<DateTime>(nullable: false),
                    TotalFacturado = table.Column<float>(nullable: false),
                    Retencion = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Viveros",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    TsEfectiva = table.Column<float>(nullable: false),
                    TsDescontada = table.Column<float>(nullable: false),
                    Descuento = table.Column<float>(nullable: false),
                    CostoInicial = table.Column<float>(nullable: false),
                    CostoFinal = table.Column<float>(nullable: false),
                    ValorNeto = table.Column<float>(nullable: false),
                    ValorRecaudado = table.Column<float>(nullable: false),
                    ValorEntero = table.Column<float>(nullable: false),
                    TCEA = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viveros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Plantas_Viveros",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    viveroid = table.Column<int>(nullable: true),
                    plantaid = table.Column<int>(nullable: true),
                    fechaRegistro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantas_Viveros", x => x.id);
                    table.ForeignKey(
                        name: "FK_Plantas_Viveros_Plantas_plantaid",
                        column: x => x.plantaid,
                        principalTable: "Plantas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plantas_Viveros_Viveros_viveroid",
                        column: x => x.viveroid,
                        principalTable: "Viveros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plantas_Viveros_plantaid",
                table: "Plantas_Viveros",
                column: "plantaid");

            migrationBuilder.CreateIndex(
                name: "IX_Plantas_Viveros_viveroid",
                table: "Plantas_Viveros",
                column: "viveroid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plantas_Viveros");

            migrationBuilder.DropTable(
                name: "Plantas");

            migrationBuilder.DropTable(
                name: "Viveros");
        }
    }
}
