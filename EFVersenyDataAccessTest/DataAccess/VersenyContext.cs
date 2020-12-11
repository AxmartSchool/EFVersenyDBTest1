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

        public DbSet<Profil> Profilok { get; set; }



    }
}
