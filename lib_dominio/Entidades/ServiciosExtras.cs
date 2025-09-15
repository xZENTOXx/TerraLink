
namespace lib_dominio.Entidades
{
    public class ServiciosExtras
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }

        public required decimal Precio { get; set; }

        public bool Estado = false;

    }
}
