using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class ProveedorBLL
    {
        private readonly ProveedorDAL _proveedorDAL;
        private readonly InventarioDbContext _db;

        public ProveedorBLL()
        {
            this._db = new InventarioDbContext();
            _proveedorDAL = new ProveedorDAL(_db);
        }

        // Insertar un nuevo proveedor
        public int Insertar(Proveedor proveedor)
        {
            // Validar datos del proveedor
            if (!ValidarProveedor(proveedor))
                return 0;

            // Insertar proveedor en la base de datos
            return _proveedorDAL.Insertar(proveedor);
        }

        private bool ValidarProveedor(Proveedor proveedor)
        {
            // Implementar lógica de validación de proveedor
            if (string.IsNullOrEmpty(proveedor.Nombre))
                return false;

            if (string.IsNullOrEmpty(proveedor.Telefono))
                return false;

            // Agregar más validaciones según las reglas de negocio

            return true;
        }
    }
}
