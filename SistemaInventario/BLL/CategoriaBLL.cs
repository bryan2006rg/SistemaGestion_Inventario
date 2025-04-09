using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class CategoriaBLL
    {
        private readonly CategoriaDAL _categoriaDAL;
        private readonly InventarioDbContext _db;

        public CategoriaBLL()
        {
            this._db = new InventarioDbContext();
            _categoriaDAL = new CategoriaDAL(_db);
        }

        // Insertar una nueva categoría
        public int Insertar(Categoria categoria)
        {
            // Validar datos de la categoría
            if (!ValidarCategoria(categoria))
                return 0;

            // Insertar categoría en la base de datos
            return _categoriaDAL.Insertar(categoria);
        }

        private bool ValidarCategoria(Categoria categoria)
        {
            // Implementar lógica de validación de categoría
            if (string.IsNullOrEmpty(categoria.Nombre))
                return false;

            // Agregar más validaciones según las reglas de negocio

            return true;
        }
    }
}
