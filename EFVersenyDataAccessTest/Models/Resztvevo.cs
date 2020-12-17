using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFVersenyDataAccessTest.Models
{
   public class Resztvevo
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Profil")]
        public int ProfilId { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("Verseny")]
        public int VersenyId { get; set; }
        public int Seed { get; set; }
        [MaxLength(20)]
        public string Statusz { get; set; }
        public Profil Profil { get; set; }
        public Verseny Verseny { get; set; }

    }
}
