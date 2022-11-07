using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int AlumnoId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }
        public DateTime? FechaNaciemiento { get; set; }


    }
}
