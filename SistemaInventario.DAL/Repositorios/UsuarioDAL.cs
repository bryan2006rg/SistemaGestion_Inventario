using System.Collections.Generic;
using System.Linq;
using SistemaInventario.EL;
using SistemaInventario.DAL.Contexto;

namespace SistemaInventario.DAL.Repositorios
{
    public class UsuarioDAL
    {
        public List<Usuario> ObtenerTodos()
        {
            using (var db = new InventarioDbContext())
            {
                return db.Usuarios.ToList();
            }
        }

        public void Insertar(Usuario usuario)
        {
            using (var db = new InventarioDbContext())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }

        public void Actualizar(Usuario usuario)
        {
            using (var db = new InventarioDbContext())
            {
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Eliminar(int idUsuario)
        {
            using (var db = new InventarioDbContext())
            {
                var usuario = db.Usuarios.Find(idUsuario);
                if (usuario != null)
                {
                    db.Usuarios.Remove(usuario);
                    db.SaveChanges();
                }
            }
        }
    }
}
