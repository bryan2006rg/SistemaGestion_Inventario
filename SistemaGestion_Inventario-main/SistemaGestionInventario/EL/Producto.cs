using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Producto
    {
        // Atributos privados
        private int id_producto;         // Identificador único
        private string nombre;           // Nombre del producto
        private string descripcion;      // Descripción del producto
        private float precio;            // Precio del producto
        private int cantidad;            // Cantidad disponible
        private string talla;            // Talla del producto
        private string color;            // Color del producto

        // Constructor
        public Producto(int id_producto, string nombre, string descripcion,
                        float precio, int cantidad, string talla, string color)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
            this.talla = talla;
            this.color = color;
        }

        // Métodos de acceso (getters)
        public int GetIdProducto()
        {
            return id_producto;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        public string GetTalla()
        {
            return talla;
        }

        public string GetColor()
        {
            return color;
        }

        // Métodos de modificación (setters)
        public void SetPrecio(float nuevo_precio)
        {
            if (nuevo_precio >= 0)
            {
                precio = nuevo_precio;
            }
        }

        public void AgregarStock(int cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void QuitarStock(int cantidad)
        {
            if (cantidad > 0 && cantidad <= this.cantidad)
            {
                this.cantidad -= cantidad;
            }
        }

        public override string ToString()
        {
            return $"{nombre} (ID: {id_producto}) - Precio: {precio} - Cantidad: {cantidad}";
        }
    }
}