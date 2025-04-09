using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

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
        [StringLength(20)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }
    }
}
