using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFVersenyDataAccessTest.Models
{
    public class Profil
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public String ProfilNev { get; set; }
        public DateTime SzuletesiIdo { get; set; }
        public DateTime RegisztracioIdeje { get; set; }
        [Required]
        [MaxLength(5)]
        public string Nem { get; set; }
        [Required]
        [MaxLength(20)]
        public String VezetekNev { get; set; }
        [Required]
        [MaxLength(20)]
        public String KeresztNev { get; set; }
        [Required]
        [MaxLength(50)]
        public String EmailCim { get; set; }




    }
}
