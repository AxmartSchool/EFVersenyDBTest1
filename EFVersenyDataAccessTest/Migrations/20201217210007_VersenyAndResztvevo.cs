using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace EFVersenyDataAccessTest.Migrations
{
    public partial class VersenyAndResztvevo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Versenyek",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KezdesIdeje = table.Column<DateTime>(nullable: false),
                    Nev = table.Column<string>(maxLength: 50, nullable: false),
                    Szabalyzat = table.Column<string>(type: "mediumtext", nullable: true),
                    JatekMod = table.Column<string>(maxLength: 20, nullable: false),
                    Statusz = table.Column<string>(maxLength: 20, nullable: false),
                    JatekId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versenyek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Versenyek_Jatekok_JatekId",
                        column: x => x.JatekId,
                        principalTable: "Jatekok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resztvevok",
                columns: table => new
                {
                    ProfilId = table.Column<int>(nullable: false),
                    VersenyId = table.Column<int>(nullable: false),
                    Seed = table.Column<int>(nullable: false),
                    Statusz = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resztvevok", x => new { x.ProfilId, x.VersenyId });
                    table.ForeignKey(
                        name: "FK_Resztvevok_Profilok_ProfilId",
                        column: x => x.ProfilId,
                        principalTable: "Profilok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resztvevok_Versenyek_VersenyId",
                        column: x => x.VersenyId,
                        principalTable: "Versenyek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resztvevok_VersenyId",
                table: "Resztvevok",
                column: "VersenyId");

            migrationBuilder.CreateIndex(
                name: "IX_Versenyek_JatekId",
                table: "Versenyek",
                column: "JatekId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resztvevok");

            migrationBuilder.DropTable(
                name: "Versenyek");
        }
    }
}
