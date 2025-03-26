using System;
using System.Collections.Generic;

namespace Usuarios
{
    public class Rol
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }

        public Rol(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    public class Usuario
    {
        // Identificador único
        public Guid Id { get; private set; }

        // Propiedades encapsuladas
        public string Nombre { get; private set; }
        public string Correo { get; private set; }
        public string Contraseña { get; private set; }
        public Rol RolUsuario { get; private set; } // Relación de composición

        // Lista de registros de actividad (Ejemplo de agregación)
        private List<string> historialActividades;

        // Constructor
        public Usuario(string nombre, string correo, string contraseña, Rol rol)
        {
            Id = Guid.NewGuid(); // Generación de identificador único
            Nombre = nombre;
            Correo = correo;
            Contraseña = HashPassword(contraseña);
            RolUsuario = rol;
            historialActividades = new List<string>();
        }

        // Método para cambiar contraseña
        public void CambiarContraseña(string nuevaContraseña)
        {
            Contraseña = HashPassword(nuevaContraseña);
        }

        // Método para registrar actividad del usuario
        public void RegistrarActividad(string actividad)
        {
            historialActividades.Add(actividad);
        }

        // Método para obtener el historial de actividades
        public IReadOnlyList<string> ObtenerHistorialActividades()
        {
            return historialActividades.AsReadOnly();
        }

        // Método privado para simular el hash de la contraseña
        private string HashPassword(string password)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }
}

