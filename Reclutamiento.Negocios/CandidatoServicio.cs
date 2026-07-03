using Reclutamiento.Datos;

namespace Reclutamiento.Negocio
{
    // capa de negocio - contiene la logica y validaciones del sistema
    public class CandidatoServicio
    {
        private CandidatoDAO _dao = new CandidatoDAO();

        // metodo normal - registra un candidato con validaciones
        public void RegistrarCandidato(string cedula, string nombre, string email, string telefono, bool esInterno)
        {
            // validaciones antes de insertar
            if (string.IsNullOrEmpty(cedula))
                throw new ArgumentException("La cedula es requerida");
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("El email es requerido");

            Candidato c = new Candidato(cedula, nombre, email, telefono, esInterno);
            _dao.Insertar(c);
        }

        // metodo normal  - obtiene todos los candidatos de la BD
        public List<Candidato> ObtenerCandidatos()
        {
            return _dao.ObtenerTodos();
        }

        // metodo normal - elimina un candidato por su ID
        public void EliminarCandidato(int id)
        {
            _dao.Eliminar(id);
        }

        // metodo normal - actualiza los datos de un candidato
        public void ActualizarCandidato(Candidato c)
        {
            _dao.Actualizar(c);
        }

        // metodo como funcion - con lambda para filtrar candidatos por tipo y tiene el uso de delegados y expresiones lambda
        public List<Candidato> FiltrarPorTipo(bool esInterno)
        {
            List<Candidato> todos = _dao.ObtenerTodos();
            // lambda: recibe un candidato y retorna true si su tipo coincide
            Func<Candidato, bool> filtro = c => c.EsInterno == esInterno;
            return todos.Where(filtro).ToList();
        }
    }
}