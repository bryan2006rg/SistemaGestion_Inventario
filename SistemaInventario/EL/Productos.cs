using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Productos")]
    public class Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }

        [Required, StringLength(100)]
        [Column(name: "nombre_producto")]
        public string Nombre { get; set; }

        [StringLength(500)]
        [Column(name: "descripcion_producto")]
        public string Descripcion { get; set; }

        [Required]
        [Column(name: "precio_producto")]
        public decimal Precio { get; set; }

        [Required]
        [Column(name: "stock_producto")]
        public int Stock { get; set; }

        // Se agrega llave foranea
        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }
        public virtual Categorias Categoria { get; set; }
    }
}
