using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Contrasena { get; set; }

        [Required]
        [StringLength(50)]
        public string Rol { get; set; }
    }
}
