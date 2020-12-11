using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace EFVersenyDataAccessTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profilok",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProfilNev = table.Column<string>(maxLength: 20, nullable: false),
                    SzuletesiIdo = table.Column<DateTime>(nullable: false),
                    RegisztracioIdeje = table.Column<DateTime>(nullable: false),
                    Nem = table.Column<string>(maxLength: 5, nullable: false),
                    VezetekNev = table.Column<string>(maxLength: 20, nullable: false),
                    KeresztNev = table.Column<string>(maxLength: 20, nullable: false),
                    EmailCim = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profilok", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profilok");
        }
    }
}
