using EFVersenyDataAccessTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFVersenyDataAccessTest.DataAccess
{
    public class VersenyContext : DbContext
    {

        public VersenyContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Resztvevo>().HasKey(x => new { x.ProfilId, x.VersenyId });


        }


        public DbSet<Profil> Profilok { get; set; }
        public DbSet<JatekosNev> JatekosNevek { get; set; }
        public DbSet<Jatek> Jatekok { get; set; }
        public DbSet<Verseny> Versenyek { get; set; }
        public DbSet<Resztvevo> Resztvevok { get; set; }
        public DbSet<Meccs> Meccsek { get; set; }


    }
}
