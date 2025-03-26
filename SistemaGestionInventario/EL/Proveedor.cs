namespace EL
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

        public Proveedor() { }

        public Proveedor(int id, string nombre, string telefono, string email, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Teléfono: {Telefono}, Email: {Email}, Dirección: {Direccion}";
        }
    }
}
