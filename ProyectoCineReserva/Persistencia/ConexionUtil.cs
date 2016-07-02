namespace ProyectoCineReserva.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Server=(local); DataBase=BDCINE; integrated security= true";
        }
    }
}