using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class DBIni2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CedulaCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoCliente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "cliente_det",
                columns: table => new
                {
                    ClienteDetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente_det", x => x.ClienteDetId);
                    table.ForeignKey(
                        name: "FK_cliente_det_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "garante",
                columns: table => new
                {
                    GaranteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGarante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoGarante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CedulaGarante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoGarante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_garante", x => x.GaranteId);
                    table.ForeignKey(
                        name: "FK_garante_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comportamiento_cliente",
                columns: table => new
                {
                    ComportamientClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deuda_casas_comerciales = table.Column<double>(type: "float", nullable: false),
                    Deuda_otras_entidades_financieras = table.Column<double>(type: "float", nullable: false),
                    fecha_deuda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalculoDeudasCliente = table.Column<bool>(type: "bit", nullable: false),
                    ClienteDetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comportamiento_cliente", x => x.ComportamientClienteId);
                    table.ForeignKey(
                        name: "FK_comportamiento_cliente_cliente_det_ClienteDetId",
                        column: x => x.ClienteDetId,
                        principalTable: "cliente_det",
                        principalColumn: "ClienteDetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "costo_cuota",
                columns: table => new
                {
                    CostoCuotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalculoCuota = table.Column<double>(type: "float", nullable: false),
                    CalculoAmortizacion = table.Column<double>(type: "float", nullable: false),
                    TasaAnual = table.Column<double>(type: "float", nullable: false),
                    CalculoPagoTotal = table.Column<double>(type: "float", nullable: false),
                    MontoSolicitado = table.Column<double>(type: "float", nullable: false),
                    NumeroCuotas = table.Column<double>(type: "float", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Cliente_DetClienteDetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costo_cuota", x => x.CostoCuotaId);
                    table.ForeignKey(
                        name: "FK_costo_cuota_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_costo_cuota_cliente_det_Cliente_DetClienteDetId",
                        column: x => x.Cliente_DetClienteDetId,
                        principalTable: "cliente_det",
                        principalColumn: "ClienteDetId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "declaracion_cliente",
                columns: table => new
                {
                    DeclaracionPatrimonioClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreBien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvaluoBienParticular = table.Column<double>(type: "float", nullable: false),
                    AvaluoBienMunicipio = table.Column<double>(type: "float", nullable: false),
                    CalculoPatrimonioCliente = table.Column<bool>(type: "bit", nullable: false),
                    ClienteDetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_declaracion_cliente", x => x.DeclaracionPatrimonioClienteId);
                    table.ForeignKey(
                        name: "FK_declaracion_cliente_cliente_det_ClienteDetId",
                        column: x => x.ClienteDetId,
                        principalTable: "cliente_det",
                        principalColumn: "ClienteDetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gastos_cliente",
                columns: table => new
                {
                    GastosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gasto_agua = table.Column<double>(type: "float", nullable: false),
                    gasto_luz = table.Column<double>(type: "float", nullable: false),
                    gasto_telefono = table.Column<double>(type: "float", nullable: false),
                    gasto_internet = table.Column<double>(type: "float", nullable: false),
                    gastos_totales = table.Column<double>(type: "float", nullable: false),
                    aprobacion_gastos = table.Column<bool>(type: "bit", nullable: false),
                    ClienteDetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gastos_cliente", x => x.GastosId);
                    table.ForeignKey(
                        name: "FK_gastos_cliente_cliente_det_ClienteDetId",
                        column: x => x.ClienteDetId,
                        principalTable: "cliente_det",
                        principalColumn: "ClienteDetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historial_cliente",
                columns: table => new
                {
                    HistorialClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroCuota = table.Column<double>(type: "float", nullable: false),
                    FechaPagoReal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaPagoSolicitada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CantidadPagada = table.Column<double>(type: "float", nullable: false),
                    CantidadSolicitada = table.Column<double>(type: "float", nullable: false),
                    Saldo = table.Column<double>(type: "float", nullable: false),
                    DiasRetrasoCliente = table.Column<bool>(type: "bit", nullable: false),
                    ClienteDetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historial_cliente", x => x.HistorialClienteId);
                    table.ForeignKey(
                        name: "FK_historial_cliente_cliente_det_ClienteDetId",
                        column: x => x.ClienteDetId,
                        principalTable: "cliente_det",
                        principalColumn: "ClienteDetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "garante_det",
                columns: table => new
                {
                    GaranteDetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GaranteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_garante_det", x => x.GaranteDetId);
                    table.ForeignKey(
                        name: "FK_garante_det_garante_GaranteId",
                        column: x => x.GaranteId,
                        principalTable: "garante",
                        principalColumn: "GaranteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comportamiento_garante",
                columns: table => new
                {
                    ComportamientGaranteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deuda_casas_comerciales = table.Column<double>(type: "float", nullable: false),
                    Deuda_otras_entidades_financieras = table.Column<double>(type: "float", nullable: false),
                    CalculoDeudasGarante = table.Column<bool>(type: "bit", nullable: false),
                    fecha_deuda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GaranteDetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comportamiento_garante", x => x.ComportamientGaranteId);
                    table.ForeignKey(
                        name: "FK_comportamiento_garante_garante_det_GaranteDetId",
                        column: x => x.GaranteDetId,
                        principalTable: "garante_det",
                        principalColumn: "GaranteDetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "declaracion_garante",
                columns: table => new
                {
                    DeclaracionPatrimonioGaranteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreBien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvaluoBienParticular = table.Column<double>(type: "float", nullable: false),
                    AvaluoBienMunicipio = table.Column<double>(type: "float", nullable: false),
                    CalculoPatrimonioGarante = table.Column<bool>(type: "bit", nullable: false),
                    GaranteDetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_declaracion_garante", x => x.DeclaracionPatrimonioGaranteId);
                    table.ForeignKey(
                        name: "FK_declaracion_garante_garante_det_GaranteDetId",
                        column: x => x.GaranteDetId,
                        principalTable: "garante_det",
                        principalColumn: "GaranteDetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historial_garante",
                columns: table => new
                {
                    HistorialGaranteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroCuota = table.Column<double>(type: "float", nullable: false),
                    FechaPagoReal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaPagoSolicitada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CantidadPagada = table.Column<double>(type: "float", nullable: false),
                    CantidadSolicitada = table.Column<double>(type: "float", nullable: false),
                    Saldo = table.Column<double>(type: "float", nullable: false),
                    DiasRetrasoGarante = table.Column<bool>(type: "bit", nullable: false),
                    GaranteDetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historial_garante", x => x.HistorialGaranteId);
                    table.ForeignKey(
                        name: "FK_historial_garante_garante_det_GaranteDetId",
                        column: x => x.GaranteDetId,
                        principalTable: "garante_det",
                        principalColumn: "GaranteDetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cliente_det_ClienteId",
                table: "cliente_det",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_comportamiento_cliente_ClienteDetId",
                table: "comportamiento_cliente",
                column: "ClienteDetId");

            migrationBuilder.CreateIndex(
                name: "IX_comportamiento_garante_GaranteDetId",
                table: "comportamiento_garante",
                column: "GaranteDetId");

            migrationBuilder.CreateIndex(
                name: "IX_costo_cuota_Cliente_DetClienteDetId",
                table: "costo_cuota",
                column: "Cliente_DetClienteDetId");

            migrationBuilder.CreateIndex(
                name: "IX_costo_cuota_ClienteId",
                table: "costo_cuota",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_declaracion_cliente_ClienteDetId",
                table: "declaracion_cliente",
                column: "ClienteDetId");

            migrationBuilder.CreateIndex(
                name: "IX_declaracion_garante_GaranteDetId",
                table: "declaracion_garante",
                column: "GaranteDetId");

            migrationBuilder.CreateIndex(
                name: "IX_garante_ClienteId",
                table: "garante",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_garante_det_GaranteId",
                table: "garante_det",
                column: "GaranteId");

            migrationBuilder.CreateIndex(
                name: "IX_gastos_cliente_ClienteDetId",
                table: "gastos_cliente",
                column: "ClienteDetId");

            migrationBuilder.CreateIndex(
                name: "IX_historial_cliente_ClienteDetId",
                table: "historial_cliente",
                column: "ClienteDetId");

            migrationBuilder.CreateIndex(
                name: "IX_historial_garante_GaranteDetId",
                table: "historial_garante",
                column: "GaranteDetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comportamiento_cliente");

            migrationBuilder.DropTable(
                name: "comportamiento_garante");

            migrationBuilder.DropTable(
                name: "costo_cuota");

            migrationBuilder.DropTable(
                name: "declaracion_cliente");

            migrationBuilder.DropTable(
                name: "declaracion_garante");

            migrationBuilder.DropTable(
                name: "gastos_cliente");

            migrationBuilder.DropTable(
                name: "historial_cliente");

            migrationBuilder.DropTable(
                name: "historial_garante");

            migrationBuilder.DropTable(
                name: "cliente_det");

            migrationBuilder.DropTable(
                name: "garante_det");

            migrationBuilder.DropTable(
                name: "garante");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
