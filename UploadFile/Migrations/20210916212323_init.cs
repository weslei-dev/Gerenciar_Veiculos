using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadFile.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataFiles = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "Intercambio",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destinatario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEmbarque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeEmpresaEmbarcadora = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intercambio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Romaneio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoRota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeioDeTransporte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDeTransporte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDeCarga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodicaoDeFrete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerieDaNotaFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeorDaNotaFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDaEmissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Natureza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acondicionamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valordanota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cubagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICMS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seguro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantidadeDeVolumes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperacaoNotaFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoDeEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInicialEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraInicialEnterga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataFinalEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntercambioId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notas_Intercambio_IntercambioId",
                        column: x => x.IntercambioId,
                        principalTable: "Intercambio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FiscalParticipantes",
                columns: table => new
                {
                    RazaoSocial = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CNPJs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InscricaoEstadual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ceps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaFrete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteRazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteCNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteInscricaoEstadual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteLogradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteBairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteCidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteCep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteCodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FretecodigoMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteTelefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperacaoNotaFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoDeEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInicialEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraInicialEnterga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataFinalEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotaFiscalId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiscalParticipantes", x => x.RazaoSocial);
                    table.ForeignKey(
                        name: "FK_FiscalParticipantes_Notas_NotaFiscalId",
                        column: x => x.NotaFiscalId,
                        principalTable: "Notas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FiscalParticipantes_NotaFiscalId",
                table: "FiscalParticipantes",
                column: "NotaFiscalId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_IntercambioId",
                table: "Notas",
                column: "IntercambioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "FiscalParticipantes");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Intercambio");
        }
    }
}
