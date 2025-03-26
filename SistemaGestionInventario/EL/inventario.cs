using System;
using System.Collections.Generic;

public class Producto
{
    // Propiedades del Producto
    public int Id { get; private set; }  // Identificador único (auto incrementado)
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }

    // Constructor para crear un nuevo producto
    public Producto(int id, string nombre, decimal precio, int cantidad)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    // Método para actualizar la cantidad del producto
    public void ActualizarCantidad(int nuevaCantidad)
    {
        if (nuevaCantidad >= 0)
        {
            Cantidad = nuevaCantidad;
        }
        else
        {
            throw new ArgumentException("La cantidad no puede ser negativa.");
        }
    }
}

public class Inventario
{
    // Lista de productos (agregación, un inventario puede tener varios productos)
    private List<Producto> productos;

    // Constructor de la clase Inventario
    public Inventario()
    {
        productos = new List<Producto>();
    }

    // Método para agregar un producto al inventario
    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
    }

    // Método para obtener un producto por su identificador
    public Producto ObtenerProducto(int id)
    {
        return productos.Find(p => p.Id == id);
    }

    // Método para obtener el valor total del inventario (precio * cantidad de cada producto)
    public decimal ObtenerValorTotalInventario()
    {
        decimal valorTotal = 0;
        foreach (var producto in productos)
        {
            valorTotal += producto.Precio * producto.Cantidad;
        }
        return valorTotal;
    }

    // Propiedad solo de lectura que devuelve el número total de productos en el inventario
    public int TotalProductos => productos.Count;
}

class Program
{
    static void Main(string[] args)
    {
        // Crear productos
        Producto producto1 = new Producto(1, "Laptop", 1500.00m, 10);
        Producto producto2 = new Producto(2, "Teclado", 50.00m, 50);

        // Crear inventario y agregar productos
        Inventario inventario = new Inventario();
        inventario.AgregarProducto(producto1);
        inventario.AgregarProducto(producto2);

        // Mostrar información
        Console.WriteLine($"Valor total del inventario: {inventario.ObtenerValorTotalInventario()}");
        Console.WriteLine($"Total de productos en el inventario: {inventario.TotalProductos}");

        // Actualizar cantidad de un producto
        producto1.ActualizarCantidad(12);
        Console.WriteLine($"Nueva cantidad de la Laptop: {producto1.Cantidad}");
    }
}

