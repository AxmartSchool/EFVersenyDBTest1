using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace EFVersenyDataAccessTest.Migrations
{
    public partial class JatekokEsJatekosNevek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jatekok",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nev = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jatekok", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JatekosNevek",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nev = table.Column<string>(maxLength: 50, nullable: false),
                    JatekId = table.Column<int>(nullable: true),
                    ProfilId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JatekosNevek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JatekosNevek_Jatekok_JatekId",
                        column: x => x.JatekId,
                        principalTable: "Jatekok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JatekosNevek_Profilok_ProfilId",
                        column: x => x.ProfilId,
                        principalTable: "Profilok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JatekosNevek_JatekId",
                table: "JatekosNevek",
                column: "JatekId");

            migrationBuilder.CreateIndex(
                name: "IX_JatekosNevek_ProfilId",
                table: "JatekosNevek",
                column: "ProfilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JatekosNevek");

            migrationBuilder.DropTable(
                name: "Jatekok");
        }
    }
}
