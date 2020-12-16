using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFVersenyDataAccessTest.Models
{
   public class Jatek
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nev { get; set; }
    }
}
