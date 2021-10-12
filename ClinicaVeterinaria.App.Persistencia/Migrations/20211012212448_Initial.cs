using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaVeterinaria.App.Persistencia.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorarioLaboral = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LicenciaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especializacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoVeterinario = table.Column<int>(type: "int", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Veterinario_HorarioLaboral = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Veterinario_LicenciaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Veterinario_Especializacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Veterinario_EstadoVeterinario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    AgendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeterinarioId = table.Column<int>(type: "int", nullable: true),
                    AuxiliarId = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.AgendaId);
                    table.ForeignKey(
                        name: "FK_Agendas_Personas_AuxiliarId",
                        column: x => x.AuxiliarId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendas_Personas_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    MascotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripción = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ownerId = table.Column<int>(type: "int", nullable: true),
                    auxiliarId = table.Column<int>(type: "int", nullable: true),
                    veterinarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.MascotaId);
                    table.ForeignKey(
                        name: "FK_Mascotas_Personas_auxiliarId",
                        column: x => x.auxiliarId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mascotas_Personas_ownerId",
                        column: x => x.ownerId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mascotas_Personas_veterinarioId",
                        column: x => x.veterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Anotaciones",
                columns: table => new
                {
                    AnotacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ownerId = table.Column<int>(type: "int", nullable: true),
                    MascotaId = table.Column<int>(type: "int", nullable: true),
                    veterinarioId = table.Column<int>(type: "int", nullable: true),
                    auxiliarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anotaciones", x => x.AnotacionId);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Mascotas_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "MascotaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Personas_auxiliarId",
                        column: x => x.auxiliarId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Personas_ownerId",
                        column: x => x.ownerId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Personas_veterinarioId",
                        column: x => x.veterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chequeos",
                columns: table => new
                {
                    ChequeoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pulso = table.Column<int>(type: "int", nullable: false),
                    PresionArterial = table.Column<int>(type: "int", nullable: false),
                    Consiente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoSangre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperatura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnotacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chequeos", x => x.ChequeoId);
                    table.ForeignKey(
                        name: "FK_Chequeos_Anotaciones_AnotacionId",
                        column: x => x.AnotacionId,
                        principalTable: "Anotaciones",
                        principalColumn: "AnotacionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    DiagnosticoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Receta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gravedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MascotaId = table.Column<int>(type: "int", nullable: true),
                    AnotacionId = table.Column<int>(type: "int", nullable: true),
                    ChequeoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.DiagnosticoId);
                    table.ForeignKey(
                        name: "FK_Diagnosticos_Anotaciones_AnotacionId",
                        column: x => x.AnotacionId,
                        principalTable: "Anotaciones",
                        principalColumn: "AnotacionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnosticos_Chequeos_ChequeoId",
                        column: x => x.ChequeoId,
                        principalTable: "Chequeos",
                        principalColumn: "ChequeoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnosticos_Mascotas_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "MascotaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaClinicas",
                columns: table => new
                {
                    HistoriaClinicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnotacionId = table.Column<int>(type: "int", nullable: true),
                    ChequeoId = table.Column<int>(type: "int", nullable: true),
                    MascotaId = table.Column<int>(type: "int", nullable: true),
                    ownerId = table.Column<int>(type: "int", nullable: true),
                    veterinarioId = table.Column<int>(type: "int", nullable: true),
                    auxiliarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinicas", x => x.HistoriaClinicaId);
                    table.ForeignKey(
                        name: "FK_HistoriaClinicas_Anotaciones_AnotacionId",
                        column: x => x.AnotacionId,
                        principalTable: "Anotaciones",
                        principalColumn: "AnotacionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoriaClinicas_Chequeos_ChequeoId",
                        column: x => x.ChequeoId,
                        principalTable: "Chequeos",
                        principalColumn: "ChequeoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoriaClinicas_Mascotas_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "MascotaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoriaClinicas_Personas_auxiliarId",
                        column: x => x.auxiliarId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoriaClinicas_Personas_ownerId",
                        column: x => x.ownerId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoriaClinicas_Personas_veterinarioId",
                        column: x => x.veterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_AuxiliarId",
                table: "Agendas",
                column: "AuxiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_VeterinarioId",
                table: "Agendas",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_auxiliarId",
                table: "Anotaciones",
                column: "auxiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_MascotaId",
                table: "Anotaciones",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_ownerId",
                table: "Anotaciones",
                column: "ownerId");

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_veterinarioId",
                table: "Anotaciones",
                column: "veterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Chequeos_AnotacionId",
                table: "Chequeos",
                column: "AnotacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_AnotacionId",
                table: "Diagnosticos",
                column: "AnotacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_ChequeoId",
                table: "Diagnosticos",
                column: "ChequeoId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_MascotaId",
                table: "Diagnosticos",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_AnotacionId",
                table: "HistoriaClinicas",
                column: "AnotacionId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_auxiliarId",
                table: "HistoriaClinicas",
                column: "auxiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_ChequeoId",
                table: "HistoriaClinicas",
                column: "ChequeoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_MascotaId",
                table: "HistoriaClinicas",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_ownerId",
                table: "HistoriaClinicas",
                column: "ownerId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_veterinarioId",
                table: "HistoriaClinicas",
                column: "veterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_auxiliarId",
                table: "Mascotas",
                column: "auxiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_ownerId",
                table: "Mascotas",
                column: "ownerId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_veterinarioId",
                table: "Mascotas",
                column: "veterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Cedula",
                table: "Personas",
                column: "Cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Username",
                table: "Personas",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "HistoriaClinicas");

            migrationBuilder.DropTable(
                name: "Chequeos");

            migrationBuilder.DropTable(
                name: "Anotaciones");

            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
