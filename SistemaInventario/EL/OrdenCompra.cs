using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("OrdenCompra")]
    public class OrdenCompra
    {
        [Key]
        public int IdOrdenCompra { get; set; }

        [Required]
        public int IdProveedor { get; set; }

        [ForeignKey("IdProveedor")]
        public virtual Proveedor Proveedor { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioUnitario { get; set; }

        [Required]
        public DateTime FechaOrden { get; set; }

        [Required]
        public DateTime FechaEntrega { get; set; }

        [Required]
        [StringLength(100)]
        public string Estado { get; set; }
    }
}
