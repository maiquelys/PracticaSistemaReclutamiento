using Reclutamiento.Datos;

namespace Reclutamiento.Negocio
{
    public class CandidatoServicio
    {
        private CandidatoDAO _dao = new CandidatoDAO();

        // metodo para registrar candidato
        public void RegistrarCandidato(string cedula, string nombre, string email, string telefono, bool esInterno)
        {
            if (string.IsNullOrEmpty(cedula))
                throw new ArgumentException("La cedula es requerida");
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("El email es requerido");

            Candidato c = new Candidato(cedula, nombre, email, telefono, esInterno);
            _dao.Insertar(c);
        }

        // metodo para obtener datos
        public List<Candidato> ObtenerCandidatos()
        {
            return _dao.ObtenerTodos();
        }

        // metodo para eliminar
        public void EliminarCandidato(int id)
        {
            _dao.Eliminar(id);
        }

        // metodo para actualizar - recibe Candidato no CandidatoServicio
        public void ActualizarCandidato(Candidato c)
        {
            _dao.Actualizar(c);
        }

        // metodo como funcion - lambda para filtrar candidatos
        public List<Candidato> FiltrarPorTipo(bool esInterno)
        {
            List<Candidato> todos = _dao.ObtenerTodos();
            Func<Candidato, bool> filtro = c => c.EsInterno == esInterno;
            return todos.Where(filtro).ToList();
        }
    }
}