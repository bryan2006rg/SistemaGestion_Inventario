using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class AjusteInventarioBLL
    {
        private readonly AjusteInventarioDAL _ajusteInventarioDAL;
        private readonly InventarioDbContext _db;

        public AjusteInventarioBLL()
        {
            this._db = new InventarioDbContext();
            _ajusteInventarioDAL = new AjusteInventarioDAL(_db);
        }

        // Insertar un nuevo ajuste de inventario
        public int Insertar(AjusteInventario ajuste)
        {
            // Validar datos del ajuste de inventario
            if (!ValidarAjusteInventario(ajuste))
                return 0;

            // Insertar ajuste de inventario en la base de datos
            return _ajusteInventarioDAL.Insertar(ajuste);
        }

        private bool ValidarAjusteInventario(AjusteInventario ajuste)
        {
            // Implementar lógica de validación de ajuste de inventario
            if (ajuste.ProductoId <= 0)
                return false;

            if (ajuste.Cantidad <= 0)
                return false;

            // Agregar más validaciones según las reglas de negocio

            return true;
        }
    }
}
