using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        [Key]
        public int ProfesorId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Titulo { get; set; }


    }
}
