using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFVersenyDataAccessTest.Models
{
    public class Meccs
    {

        public int Id { get; set; }
        [MaxLength(20)]
        public string Statusz { get; set; }
        [Column(TypeName = "tinyint")]
        public int BestOf { get; set; }
        public Profil Kihivo { get; set; }
        public Profil Kihivott { get; set; }
        [Column(TypeName = "tinyint")]
        public int KihivoPontszam { get; set; }
        [Column(TypeName = "tinyint")]
        public int KihivottPontszam { get; set; }
        public Verseny Verseny { get; set; }
    }
}
