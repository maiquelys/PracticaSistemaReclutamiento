using Microsoft.Data.SqlClient;

namespace Reclutamiento.Datos
{
    public class VacanteDAO
    {
        // metodo obtener todas las vacantes
        public List<Vacante> ObtenerTodos()
        {
            List<Vacante> lista = new List<Vacante>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Vacantes", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Vacante(
                        dr["Titulo"].ToString(),
                        dr["Descripcion"].ToString(),
                        dr["Departamento"].ToString()
                    )
                    {
                        VacanteID = (int)dr["VacanteID"],
                        Estado = dr["Estado"].ToString(),
                        FechaPublicacion = (DateTime)dr["FechaPublicacion"]
                    });
                }
            }
            return lista;
        }

        // metodo insertar vacante
        public void Insertar(Vacante v)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                string query = "INSERT INTO Vacantes (Titulo, Descripcion, Departamento, FechaPublicacion, Estado) VALUES (@Titulo, @Descripcion, @Departamento, @Fecha, @Estado)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Titulo", v.Titulo);
                cmd.Parameters.AddWithValue("@Descripcion", v.Descripcion);
                cmd.Parameters.AddWithValue("@Departamento", v.Departamento);
                cmd.Parameters.AddWithValue("@Fecha", v.FechaPublicacion);
                cmd.Parameters.AddWithValue("@Estado", v.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        // metodo eliminar vacante
        public void Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Vacantes WHERE VacanteID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }

        // metodo actualizar vacante
        public void Actualizar(Vacante v)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                string query = "UPDATE Vacantes SET Titulo=@Titulo, Descripcion=@Descripcion, Departamento=@Departamento, Estado=@Estado WHERE VacanteID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Titulo", v.Titulo);
                cmd.Parameters.AddWithValue("@Descripcion", v.Descripcion);
                cmd.Parameters.AddWithValue("@Departamento", v.Departamento);
                cmd.Parameters.AddWithValue("@Estado", v.Estado);
                cmd.Parameters.AddWithValue("@ID", v.VacanteID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}