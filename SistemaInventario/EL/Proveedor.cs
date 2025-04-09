using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    
        [Table("Proveedores")]
        public class Proveedor
        {
            [Key]
            public int IdProveedor { get; set; }

            [Required]
            [StringLength(100)]
            public string Nombre { get; set; }

            [Required]
            [StringLength(100)]
            public string Contacto { get; set; }

            [Required]
            [StringLength(20)]
            public string Telefono { get; set; }

            [Required]
            [StringLength(200)]
            public string Direccion { get; set; }
        }
    }
