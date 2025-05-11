using System.Collections.Generic;
using System.Linq;
using SistemaInventario.EL;
using SistemaInventario.DAL.Contexto;

namespace SistemaInventario.DAL.Repositorios
{
    public class ProductoDAL
    {
        public List<Producto> ObtenerTodos()
        {
            using (var db = new InventarioDbContext())
            {
                return db.Productos.ToList();
            }
        }

        public void Insertar(Producto producto)
        {
            using (var db = new InventarioDbContext())
            {
                db.Productos.Add(producto);
                db.SaveChanges();
            }
        }

        public void Actualizar(Producto producto)
        {
            using (var db = new InventarioDbContext())
            {
                db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Eliminar(int idProducto)
        {
            using (var db = new InventarioDbContext())
            {
                var producto = db.Productos.Find(idProducto);
                if (producto != null)
                {
                    db.Productos.Remove(producto);
                    db.SaveChanges();
                }
            }
        }
    }
}
