using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace EFVersenyDataAccessTest.Migrations
{
    public partial class Meccs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meccsek",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Statusz = table.Column<string>(maxLength: 20, nullable: true),
                    BestOf = table.Column<byte>(type: "tinyint", nullable: false),
                    KihivoId = table.Column<int>(nullable: true),
                    KihivottId = table.Column<int>(nullable: true),
                    KihivoPontszam = table.Column<byte>(type: "tinyint", nullable: false),
                    KihivottPontszam = table.Column<byte>(type: "tinyint", nullable: false),
                    VersenyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meccsek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meccsek_Profilok_KihivoId",
                        column: x => x.KihivoId,
                        principalTable: "Profilok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Meccsek_Profilok_KihivottId",
                        column: x => x.KihivottId,
                        principalTable: "Profilok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Meccsek_Versenyek_VersenyId",
                        column: x => x.VersenyId,
                        principalTable: "Versenyek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meccsek_KihivoId",
                table: "Meccsek",
                column: "KihivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Meccsek_KihivottId",
                table: "Meccsek",
                column: "KihivottId");

            migrationBuilder.CreateIndex(
                name: "IX_Meccsek_VersenyId",
                table: "Meccsek",
                column: "VersenyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meccsek");
        }
    }
}
