using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Inventario")]
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [StringLength(100)]
        public string UbicacionAlmacen { get; set; }
    }
}
