using Microsoft.EntityFrameworkCore.Migrations;

namespace EFVersenyDataAccessTest.Migrations
{
    public partial class SeedTestData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"INSERT INTO versenyek (KezdesIdeje,Nev,Szabalyzat,JatekMod,Statusz,JatekId) VALUES ('2021-01-08 19:35:00','TesztLiga1','TesztSzabalyzat szovege','SingleElimination','Nyitott','1');");
            migrationBuilder.Sql(@"INSERT INTO versenyek (KezdesIdeje,Nev,Szabalyzat,JatekMod,Statusz,JatekId) VALUES ('2021-02-15 16:00:00','TesztLiga2','TesztSzabalyzat szovege','SingleElimination','Nyitott','1');");
            migrationBuilder.Sql(@"INSERT INTO versenyek (KezdesIdeje,Nev,Szabalyzat,JatekMod,Statusz,JatekId) VALUES ('2021-02-15 16:00:00','TesztLiga3','TesztSzabalyzat szovege','SingleElimination','Nyitott','2');");

            migrationBuilder.Sql(@"INSERT INTO resztvevok (ProfilId,VersenyId,Seed,Statusz) VALUES (1,1,1,'Jelentkezett')");
            migrationBuilder.Sql(@"INSERT INTO resztvevok (ProfilId,VersenyId,Seed,Statusz) VALUES (2,1,2,'Jelentkezett')");
            migrationBuilder.Sql(@"INSERT INTO resztvevok (ProfilId,VersenyId,Seed,Statusz) VALUES (3,1,3,'Jelentkezett')");
            migrationBuilder.Sql(@"INSERT INTO resztvevok (ProfilId,VersenyId,Seed,Statusz) VALUES (3,2,1,'Jelentkezett')");
            migrationBuilder.Sql(@"INSERT INTO resztvevok (ProfilId,VersenyId,Seed,Statusz) VALUES (4,2,2,'Jelentkezett')");
            migrationBuilder.Sql(@"INSERT INTO resztvevok (ProfilId,VersenyId,Seed,Statusz) VALUES (2,3,1,'Jelentkezett')");
            migrationBuilder.Sql(@"INSERT INTO resztvevok (ProfilId,VersenyId,Seed,Statusz) VALUES (3,3,2,'Jelentkezett')");
            migrationBuilder.Sql(@"INSERT INTO resztvevok (ProfilId,VersenyId,Seed,Statusz) VALUES (4,3,3,'Jelentkezett')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Delete FROM versenyek WHERE Nev='TesztLiga1';");
            migrationBuilder.Sql(@"Delete FROM versenyek WHERE Nev='TesztLiga2';");
            migrationBuilder.Sql(@"Delete FROM versenyek WHERE Nev='TesztLiga3';");

            migrationBuilder.Sql(@"DELETE FROM resztvevok WHERE ProfilId=1 AND VersenyId=1;");
            migrationBuilder.Sql(@"DELETE FROM resztvevok WHERE ProfilId=2 AND VersenyId=1;");
            migrationBuilder.Sql(@"DELETE FROM resztvevok WHERE ProfilId=3 AND VersenyId=1;");
            migrationBuilder.Sql(@"DELETE FROM resztvevok WHERE ProfilId=3 AND VersenyId=2;");
            migrationBuilder.Sql(@"DELETE FROM resztvevok WHERE ProfilId=4 AND VersenyId=2;");
            migrationBuilder.Sql(@"DELETE FROM resztvevok WHERE ProfilId=2 AND VersenyId=3;");
            migrationBuilder.Sql(@"DELETE FROM resztvevok WHERE ProfilId=3 AND VersenyId=3;");
            migrationBuilder.Sql(@"DELETE FROM resztvevok WHERE ProfilId=4 AND VersenyId=3;");


        }
    }
}
