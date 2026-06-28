using Microsoft.Data.SqlClient;
namespace Reclutamiento.Datos
{
    //conexion base de datos
    public class Conexion
    {
        private static string _connectionString =
            "Server=.;Database=Reclutamiento;Integrated Security=True;TrustServerCertificate=True;";
        
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
