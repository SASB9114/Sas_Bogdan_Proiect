using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sas_Bogdan_Proiect.Migrations
{
    public partial class Magazin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Joc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Joc_Gen_GenID",
                        column: x => x.GenID,
                        principalTable: "Gen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Magazin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JocID = table.Column<int>(type: "int", nullable: false),
                    Pret = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazin", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Magazin_Joc_JocID",
                        column: x => x.JocID,
                        principalTable: "Joc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Joc_GenID",
                table: "Joc",
                column: "GenID");

            migrationBuilder.CreateIndex(
                name: "IX_Magazin_JocID",
                table: "Magazin",
                column: "JocID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Magazin");

            migrationBuilder.DropTable(
                name: "Joc");

            migrationBuilder.DropTable(
                name: "Gen");
        }
    }
}
