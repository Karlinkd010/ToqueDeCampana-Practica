using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToqueDeCampana_Practica.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblResidencia",
                columns: table => new
                {
                    id_residencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vchCiudad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    vchMunicipio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    vchEstado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    vchPais = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    vchC_postal = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_id_residencia", x => x.id_residencia);
                });

            migrationBuilder.CreateTable(
                name: "tblusuario",
                columns: table => new
                {
                    intIdusuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vchUsuario = table.Column<string>(type: "varchar(22)", unicode: false, maxLength: 22, nullable: true),
                    vchPassword = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblusuario", x => x.intIdusuario);
                });

            migrationBuilder.CreateTable(
                name: "tblUniversidad",
                columns: table => new
                {
                    id_universidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vchUniversidad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    vchTelefono = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    vchemail = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    btEstatus = table.Column<bool>(type: "bit", nullable: true),
                    id_residencia1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUniversidad", x => x.id_universidad);
                    table.ForeignKey(
                        name: "FK_tbl_residencia",
                        column: x => x.id_residencia1,
                        principalTable: "tblResidencia",
                        principalColumn: "id_residencia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblCarrera",
                columns: table => new
                {
                    id_carrera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vchCarrera = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    vchDescripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    vchSementre = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    btEstatus = table.Column<bool>(type: "bit", nullable: true),
                    id_universidad1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_id_carrera", x => x.id_carrera);
                    table.ForeignKey(
                        name: "FK_tbl_universidad1",
                        column: x => x.id_universidad1,
                        principalTable: "tblUniversidad",
                        principalColumn: "id_universidad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblAlumnos",
                columns: table => new
                {
                    id_alumnos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vchMatricula = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    vchNombre = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    vchApellidos = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    vchCurp = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    vchFechaNac = table.Column<DateTime>(type: "date", nullable: true),
                    vchTel1 = table.Column<int>(type: "int", nullable: true),
                    vchTel2 = table.Column<int>(type: "int", nullable: true),
                    vchCorreo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    vchDisertacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    vchGenero = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    vchFoto = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    vchAvatar = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    dtFechaIngreso = table.Column<DateTime>(type: "smalldatetime", nullable: true, defaultValueSql: "(getdate())"),
                    vchCalle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    intNo_exterior = table.Column<int>(type: "int", nullable: true),
                    intNo_interior = table.Column<int>(type: "int", nullable: true),
                    vchMaps = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    id_universidad2 = table.Column<int>(type: "int", nullable: true),
                    id_carrera2 = table.Column<int>(type: "int", nullable: true),
                    id_residencia2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_id_alumnos", x => x.id_alumnos);
                    table.ForeignKey(
                        name: "FK_tbl_Carrera2",
                        column: x => x.id_carrera2,
                        principalTable: "tblCarrera",
                        principalColumn: "id_carrera",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_residencia1",
                        column: x => x.id_residencia2,
                        principalTable: "tblResidencia",
                        principalColumn: "id_residencia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_universidad2",
                        column: x => x.id_universidad2,
                        principalTable: "tblUniversidad",
                        principalColumn: "id_universidad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblAlumnos_id_carrera2",
                table: "tblAlumnos",
                column: "id_carrera2");

            migrationBuilder.CreateIndex(
                name: "IX_tblAlumnos_id_residencia2",
                table: "tblAlumnos",
                column: "id_residencia2");

            migrationBuilder.CreateIndex(
                name: "IX_tblAlumnos_id_universidad2",
                table: "tblAlumnos",
                column: "id_universidad2");

            migrationBuilder.CreateIndex(
                name: "IX_tblCarrera_id_universidad1",
                table: "tblCarrera",
                column: "id_universidad1");

            migrationBuilder.CreateIndex(
                name: "IX_tblUniversidad_id_residencia1",
                table: "tblUniversidad",
                column: "id_residencia1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAlumnos");

            migrationBuilder.DropTable(
                name: "tblusuario");

            migrationBuilder.DropTable(
                name: "tblCarrera");

            migrationBuilder.DropTable(
                name: "tblUniversidad");

            migrationBuilder.DropTable(
                name: "tblResidencia");
        }
    }
}
