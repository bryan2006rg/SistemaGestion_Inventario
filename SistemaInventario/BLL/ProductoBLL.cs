using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class ProductoBLL
    {
        private readonly ProductoDAL _productoDAL;
        private readonly InventarioDbContext _db;

        public ProductoBLL()
        {
            this._db = new InventarioDbContext();
            _productoDAL = new ProductoDAL(_db);
        }

        // Insertar un nuevo producto
        public int Insertar(Producto producto)
        {
            // Validar datos del producto
            if (!ValidarProducto(producto))
                return 0;

            // Insertar producto en la base de datos
            return _productoDAL.Insertar(producto);
        }

        private bool ValidarProducto(Producto producto)
        {
            // Implementar lógica de validación de producto
            if (string.IsNullOrEmpty(producto.Nombre))
                return false;

            if (producto.Cantidad < 0)
                return false;

            // Agregar más validaciones según las reglas de negocio

            return true;
        }
    }
}