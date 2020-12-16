using Microsoft.EntityFrameworkCore.Migrations;

namespace EFVersenyDataAccessTest.Migrations
{
    public partial class SeedTestData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"INSERT INTO jatekok (Nev) VALUES ('League of Legends');");
            migrationBuilder.Sql(@"INSERT INTO jatekok (Nev) VALUES ('Counter-Strike: Global Offensive');");

            migrationBuilder.Sql(@"INSERT INTO profilok (ProfilNev,SzuletesiIdo,RegisztracioIdeje,Nem,VezetekNev,KeresztNev,EmailCim)  values ('TestMart','1993-11-11',CURRENT_TIMESTAMP(),'Férfi','Jáger','Balázs','testemail@mail.com');");
            migrationBuilder.Sql(@"INSERT INTO profilok (ProfilNev,SzuletesiIdo,RegisztracioIdeje,Nem,VezetekNev,KeresztNev,EmailCim)  values ('Abbiechan','1997-02-15',CURRENT_TIMESTAMP(),'Nő','Kiss','Abigél','testemail2@mail.com');");
            migrationBuilder.Sql(@"INSERT INTO profilok (ProfilNev,SzuletesiIdo,RegisztracioIdeje,Nem,VezetekNev,KeresztNev,EmailCim)  values ('MajerP','1991-03-11',CURRENT_TIMESTAMP(),'Férfi','Májer','Péter','testemail3@mail.com');");
            migrationBuilder.Sql(@"INSERT INTO profilok (ProfilNev,SzuletesiIdo,RegisztracioIdeje,Nem,VezetekNev,KeresztNev,EmailCim)  values ('AlexB','1998-09-21',CURRENT_TIMESTAMP(),'Férfi','Bakos','Alex','testemail4@mail.com');");

            migrationBuilder.Sql(@"INSERT INTO jatekosnevek (Nev,JatekId,ProfilId) values ('Axmart', 1,1);");
            migrationBuilder.Sql(@"INSERT INTO jatekosnevek (Nev,JatekId,ProfilId) values ('Axmart1993', 2,1);");
            migrationBuilder.Sql(@"INSERT INTO jatekosnevek (Nev,JatekId,ProfilId) values ('Abbie', 1,2);");
            migrationBuilder.Sql(@"INSERT INTO jatekosnevek (Nev,JatekId,ProfilId) values ('Peti', 1,3);");
            migrationBuilder.Sql(@"INSERT INTO jatekosnevek (Nev,JatekId,ProfilId) values ('Alex', 2,4);");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Delete FROM jatekok WHERE Nev='League of Legends';");
            migrationBuilder.Sql(@"Delete FROM jatekok WHERE Nev='Counter-Strike: Global Offensive';");

            migrationBuilder.Sql(@"Delete FROM profikok WHERE Profilnev='TestMart';");
            migrationBuilder.Sql(@"Delete FROM profikok WHERE Profilnev='Abbiechan';");
            migrationBuilder.Sql(@"Delete FROM profikok WHERE Profilnev='MajerP';");
            migrationBuilder.Sql(@"Delete FROM profikok WHERE Profilnev='AlexB';");

            migrationBuilder.Sql(@"Delete FROM jatekosnevek WHERE nev='Axmart';");
            migrationBuilder.Sql(@"Delete FROM jatekosnevek WHERE nev='Axmart1993';");
            migrationBuilder.Sql(@"Delete FROM jatekosnevek WHERE nev='Abbie';");
            migrationBuilder.Sql(@"Delete FROM jatekosnevek WHERE nev='Alex';");

            migrationBuilder.Sql(@"ALTER TABLE profilok AUTO_INCREMENT = 1;");
            migrationBuilder.Sql(@"ALTER TABLE jatekok AUTO_INCREMENT = 1;");
            migrationBuilder.Sql(@"ALTER TABLE jatekosnevek AUTO_INCREMENT = 1;");



        }
    }
}
