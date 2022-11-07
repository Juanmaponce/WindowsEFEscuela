using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Aula")]
    public class Aula
    {
        [Key]
        public int AulaId { get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Required]
        [Column(TypeName = "char")]
        public string Codigo { get; set; }
    }
}
