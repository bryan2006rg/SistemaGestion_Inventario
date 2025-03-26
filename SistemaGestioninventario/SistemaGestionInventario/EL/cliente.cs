using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class CLiente
    {
        public class Cliente
        using System;

namespace TuNombreDeEspacio
    {
        public class Cliente
        {
            // Propiedades
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }

            // Constructor
            public Cliente(int id, string nombre, string email, string telefono)
            {
                Id = id;
                Nombre = nombre;
                Email = email;
                Telefono = telefono;
            }

            // Método para mostrar información del cliente
            public void MostrarInformacion()
            {
                Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Email: {Email}, Teléfono: {Telefono}");
            }
        }
    }
