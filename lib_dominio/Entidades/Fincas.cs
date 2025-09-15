
namespace lib_dominio.Entidades
{
    public class Fincas
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Ubicacion { get; set; }
        public required int Capacidad { get; set; }
        public required string Descripcion { get; set; }
        public decimal PrecioBase { get; set; }

        public bool Estado = false;
    }
}
