using Microsoft.Data.SqlClient;

namespace Reclutamiento.Datos
{
    public class CVDAO
    {
        // obtener el CV de un candidato especifico
        public CV ObtenerPorCandidato(int candidatoID)
        {
            CV cv = null;
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CV WHERE CandidatoID = @CandidatoID", con);
                cmd.Parameters.AddWithValue("@CandidatoID", candidatoID);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cv = new CV
                    {
                        CVID = (int)dr["CVID"],
                        CandidatoID = (int)dr["CandidatoID"],
                        RutaArchivo = dr["RutaArchivo"].ToString(),
                        FechaSubida = (System.DateTime)dr["FechaSubida"]
                    };
                }
            }
            return cv;
        }

        // insertar un cv nuevo
        public void Insertar(CV cv)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                string query = "INSERT INTO CV (CandidatoID, RutaArchivo, FechaSubida) VALUES (@CandidatoID, @RutaArchivo, @FechaSubida)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CandidatoID", cv.CandidatoID);
                cmd.Parameters.AddWithValue("@RutaArchivo", cv.RutaArchivo);
                cmd.Parameters.AddWithValue("@FechaSubida", cv.FechaSubida);
                cmd.ExecuteNonQuery();
            }
        }

        // eliminar el cv de un candidato
        public void Eliminar(int cvID)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM CV WHERE CVID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", cvID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}