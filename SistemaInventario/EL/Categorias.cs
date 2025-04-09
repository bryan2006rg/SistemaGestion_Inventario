using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCategoria { get; set; }

        [Required, StringLength(100)]
        [Column(name: "nombre_categoria")]
        public string Nombre { get; set; }

        [StringLength(500)]
        [Column(name: "descripcion_categoria")]
        public string Descripcion { get; set; }

        // Relación uno a muchos con Producto
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
