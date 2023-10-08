using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhatsApp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmiteRecibo = table.Column<bool>(type: "bit", nullable: true),
                    EmiteReciboIR = table.Column<bool>(type: "bit", nullable: true),
                    EmiteReciboConvenio = table.Column<bool>(type: "bit", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: true),
                    Aniversario = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnviaMsgAniversario = table.Column<bool>(type: "bit", nullable: true),
                    CIDHD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtHrCad = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DtHrAlt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recibos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPFPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorExtenso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DtConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtEmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aniversario = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CIDHD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomePaciente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Recibos");
        }
    }
}
