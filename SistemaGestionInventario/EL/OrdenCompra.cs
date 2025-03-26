using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class OrdenCompra
    {
        public int IdOrden { get; set; }

        public DateTime Fecha { get; set; }

        public int IdUsuario { get; set; }

        public decimal Total { get; set; }

        public OrdenCompra() { }

        public OrdenCompra(int idOrden, DateTime fecha, int idUsuario, decimal total)
        {
            IdOrden = idOrden;
            Fecha = fecha;
            IdUsuario = idUsuario;
            Total = total;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Orden #{IdOrden} - Fecha: {Fecha} - Usuario: {IdUsuario} - Total: {Total:C}");
        }
    }
}
