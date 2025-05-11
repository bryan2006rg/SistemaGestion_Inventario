using System.Collections.Generic;
using System.Linq;
using SistemaInventario.EL;
using SistemaInventario.DAL.Contexto;

namespace SistemaInventario.DAL.Repositorios
{
    public class ClienteDAL
    {
        public List<Cliente> ObtenerTodos()
        {
            using (var db = new InventarioDbContext())
            {
                return db.Clientes.ToList();
            }
        }

        public void Insertar(Cliente cliente)
        {
            using (var db = new InventarioDbContext())
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }

        public void Actualizar(Cliente cliente)
        {
            using (var db = new InventarioDbContext())
            {
                db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Eliminar(int idCliente)
        {
            using (var db = new InventarioDbContext())
            {
                var cliente = db.Clientes.Find(idCliente);
                if (cliente != null)
                {
                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                }
            }
        }
    }
}
