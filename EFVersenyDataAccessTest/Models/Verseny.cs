using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFVersenyDataAccessTest.Models
{
    public class Verseny
    {
        public int Id { get; set; }
        [Required]
        public DateTime KezdesIdeje { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nev { get; set; }
        [Column(TypeName = "mediumtext")]
        public string Szabalyzat { get; set; }
        [MaxLength(20)]
        [Required]
        public string JatekMod { get; set; }
        [Required]
        [MaxLength(20)]
        public string Statusz { get; set; }
        [Required]
        public Jatek Jatek { get; set; }
        public List<Resztvevo> Resztvevok { get; set; }



    }
}
