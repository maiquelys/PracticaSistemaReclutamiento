using Microsoft.Data.SqlClient;

namespace Reclutamiento.Datos
{
    public class EntrevistaDAO
    {
        // metodo obtener todas las entrevistas
        public List<Entrevista> ObtenerTodos()
        {
            List<Entrevista> lista = new List<Entrevista>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Entrevistas", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entrevista(
                        (int)dr["CandidatoID"],
                        (int)dr["VacanteID"],
                        (int)dr["EtapaID"],
                        (decimal)dr["Puntuacion"]
                    )
                    {
                        EntrevistaID = (int)dr["EntrevistaID"],
                        Fecha = (DateTime)dr["Fecha"]
                    });
                }
            }
            return lista;
        }

        // metodo insertar entrevista
        public void Insertar(Entrevista e)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                string query = "INSERT INTO Entrevistas (CandidatoID, VacanteID, EtapaID, Fecha, Puntuacion) VALUES (@CandidatoID, @VacanteID, @EtapaID, @Fecha, @Puntuacion)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CandidatoID", e.CandidatoID);
                cmd.Parameters.AddWithValue("@VacanteID", e.VacanteID);
                cmd.Parameters.AddWithValue("@EtapaID", e.EtapaID);
                cmd.Parameters.AddWithValue("@Fecha", e.Fecha);
                cmd.Parameters.AddWithValue("@Puntuacion", e.Puntuacion);
                cmd.ExecuteNonQuery();
            }
        }

        // metodo eliminar entrevista
        public void Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Entrevistas WHERE EntrevistaID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }

        // metodo actualizar entrevista
        public void Actualizar(Entrevista e)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                string query = "UPDATE Entrevistas SET Puntuacion=@Puntuacion, EtapaID=@EtapaID, Fecha=@Fecha WHERE EntrevistaID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Puntuacion", e.Puntuacion);
                cmd.Parameters.AddWithValue("@EtapaID", e.EtapaID);
                cmd.Parameters.AddWithValue("@Fecha", e.Fecha);
                cmd.Parameters.AddWithValue("@ID", e.EntrevistaID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}