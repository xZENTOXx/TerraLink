using lib_dominio.Entidades;


namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Fincas? Fincas()
        {
            var ahora = DateTime.Now.ToString("yyyyMMddHHmmss");

            var entidad = new Fincas
            {
                Nombre = "Pruebas-" + ahora,
                Ubicacion = "Pruebas-" + ahora, 
                Capacidad = 100,
                Descripcion = "Pruebas-" + ahora,
                PrecioBase = 100000,
                Estado = true
            };

            return entidad;
        }


    }
}
