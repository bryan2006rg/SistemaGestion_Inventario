using System.Collections.Generic;
using System.Linq;
using SistemaInventario.EL;
using SistemaInventario.DAL.Contexto;

namespace SistemaInventario.DAL.Repositorios
{
    public class CategoriaDAL
    {
        public List<Categoria> ObtenerTodos()
        {
            using (var db = new InventarioDbContext())
            {
                return db.Categorias.ToList();
            }
        }

        public void Insertar(Categoria categoria)
        {
            using (var db = new InventarioDbContext())
            {
                db.Categorias.Add(categoria);
                db.SaveChanges();
            }
        }

        public void Actualizar(Categoria categoria)
        {
            using (var db = new InventarioDbContext())
            {
                db.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Eliminar(int idCategoria)
        {
            using (var db = new InventarioDbContext())
            {
                var categoria = db.Categorias.Find(idCategoria);
                if (categoria != null)
                {
                    db.Categorias.Remove(categoria);
                    db.SaveChanges();
                }
            }
        }
    }
}
