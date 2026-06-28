using Microsoft.Data.SqlClient;

namespace Reclutamiento.Datos
{
    public class DecisionFinalDAO
    {
        // metodo para obtener todas las decisiones
        public List<DecisionFinal> ObtenerTodos()
        {
            List<DecisionFinal> lista = new List<DecisionFinal>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DecisionFinal", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new DecisionFinal(
                        (int)dr["CandidatoID"],
                        (int)dr["VacanteID"],
                        dr["Decision"].ToString(),
                        dr["Comentario"].ToString()
                    )
                    {
                        DecisionID = (int)dr["DecisionID"],
                        Fecha = (DateTime)dr["Fecha"]
                    });
                }
            }
            return lista;
        }

        // metodo para insertar decision
        public void Insertar(DecisionFinal d)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                string query = "INSERT INTO DecisionFinal (CandidatoID, VacanteID, Decision, Fecha, Comentario) VALUES (@CandidatoID, @VacanteID, @Decision, @Fecha, @Comentario)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CandidatoID", d.CandidatoID);
                cmd.Parameters.AddWithValue("@VacanteID", d.VacanteID);
                cmd.Parameters.AddWithValue("@Decision", d.Decision);
                cmd.Parameters.AddWithValue("@Fecha", d.Fecha);
                cmd.Parameters.AddWithValue("@Comentario", d.Comentario);
                cmd.ExecuteNonQuery();
            }
        }

        // metodo para eliminar decision
        public void Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM DecisionFinal WHERE DecisionID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}