using Microsoft.EntityFrameworkCore.Migrations;

namespace EFVersenyDataAccessTest.Migrations
{
    public partial class SeedTestData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"INSERT INTO meccsek (Statusz,BestOf,KihivoId,KihivottId,KihivoPontszam,KihivottPontszam,VersenyId) VALUES ('Lezart',3,1,2,2,0,1);");
            migrationBuilder.Sql(@"INSERT INTO meccsek (Statusz,BestOf,KihivoId,KihivottId,KihivoPontszam,KihivottPontszam,VersenyId) VALUES ('Folyamatban',3,1,3,0,0,1);");
            migrationBuilder.Sql(@"INSERT INTO meccsek (Statusz,BestOf,KihivoId,KihivottId,KihivoPontszam,KihivottPontszam,VersenyId) VALUES ('Nyitott',5,1,1,0,0,1);");
            migrationBuilder.Sql(@"INSERT INTO meccsek (Statusz,BestOf,KihivoId,KihivottId,KihivoPontszam,KihivottPontszam,VersenyId) VALUES ('Folyamatban',3,3,4,1,0,2);");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Delete FROM meccsek;");

            migrationBuilder.Sql(@"ALTER TABLE meccsek AUTO_INCREMENT = 1;");
        }
    }
}
