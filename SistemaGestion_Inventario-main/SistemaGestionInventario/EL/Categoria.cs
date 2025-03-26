using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Categoria
    {
        // Atributos privados
        private int id_categoria;      // Identificador único de la categoría
        private string nombre;         // Nombre de la categoría
        private string descripcion;    // Descripción de la categoría

        // Constructor
        public Categoria(int id_categoria, string nombre, string descripcion)
        {
            this.id_categoria = id_categoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        // Métodos de acceso (getters)
        public int GetIdCategoria()
        {
            return id_categoria;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        // Métodos de modificación (setters)
        public void SetNombre(string nuevo_nombre)
        {
            if (!string.IsNullOrWhiteSpace(nuevo_nombre))
            {
                nombre = nuevo_nombre;
            }
        }

        public void SetDescripcion(string nueva_descripcion)
        {
            descripcion = nueva_descripcion; // Puede permitir descripciones vacías
        }

        public override string ToString()
        {
            return $"{nombre} (ID: {id_categoria}) - Descripción: {descripcion}";
        }
    }
}