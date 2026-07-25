using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace Reclutamiento.Datos
{
    public class CandidatoDAO
    {
        // metodo pa obtener todos
        public List<Candidato> ObtenerTodos()
        {
            List<Candidato> lista = new List<Candidato>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Candidatos", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Candidato(
                        dr["Cedula"].ToString(),
                        dr["Nombre"].ToString(),
                        dr["Email"].ToString(),
                        dr["Telefono"].ToString(),
                        (bool)dr["EsInterno"]
                    )
                    { CandidatoID = (int)dr["CandidatoID"] });
                }
            }
            return lista;
        }

        // metodo para insertar candidato
        public void Insertar(Candidato c)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                // 1. faltaba @Cedula en los VALUES
                string query = "INSERT INTO Candidatos (Cedula, Nombre, Email, Telefono, EsInterno) VALUES (@Cedula, @Nombre, @Email, @Telefono, @EsInterno)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Cedula", c.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@EsInterno", c.EsInterno);
                cmd.ExecuteNonQuery();
            }
        }

        // metodo para eliminar candidato
        public void Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                // 2. faltaba = @ID en el WHERE
                SqlCommand cmd = new SqlCommand("DELETE FROM Candidatos WHERE CandidatoID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }

        // metodo para actualizar candidato
        public void Actualizar(Candidato c)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                // 3. faltaba = antes de @Telefono
                // 4. namespace estaba mal escrito: Reclutamient en vez de Reclutamiento
                string query = "UPDATE Candidatos SET Nombre=@Nombre, Email=@Email, Telefono=@Telefono, EsInterno=@EsInterno WHERE CandidatoID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@EsInterno", c.EsInterno);
                cmd.Parameters.AddWithValue("@ID", c.CandidatoID);
                cmd.ExecuteNonQuery();
            }
        }

        // metodo asincrono para guardar el CV en la base de datos
        public async Task GuardarCVAsync(int candidatoId, byte[] cvBytes)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                await con.OpenAsync();
                string query = "UPDATE Candidatos SET CvPdf = @CvPdf WHERE CandidatoID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CvPdf", (object)cvBytes ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ID", candidatoId);
                await cmd.ExecuteNonQueryAsync();
            }
        }

        // metodo asincrono para obtener el CV guardado de un candidato
        public async Task<byte[]> ObtenerCVAsync(int candidatoId)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                await con.OpenAsync();
                string query = "SELECT CvPdf FROM Candidatos WHERE CandidatoID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", candidatoId);
                object resultado = await cmd.ExecuteScalarAsync();

                if (resultado == null || resultado == DBNull.Value)
                    return null;

                return (byte[])resultado;
            }
        }
    }
}