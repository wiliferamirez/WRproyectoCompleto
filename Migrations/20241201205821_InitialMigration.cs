using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WRproyectoCompleto.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WREstudiante",
                columns: table => new
                {
                    WRestudianteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WRcedulaEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WRnombreEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WRapellidoEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WRnombreRepresentanteEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WRedad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WREstudiante", x => x.WRestudianteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WREstudiante");
        }
    }
}
