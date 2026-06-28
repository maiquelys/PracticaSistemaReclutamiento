using Reclutamiento.Datos;

namespace Reclutamiento.Negocio
{
    public class EntrevistaServicio
    {
        private EntrevistaDAO _dao = new EntrevistaDAO();

        // metodo para registrar entrevista
        public void RegistrarEntrevista(int candidatoID, int vacanteID, int etapaID, decimal puntuacion)
        {
            if (puntuacion < 0 || puntuacion > 100)
                throw new ArgumentException("La puntuacion debe estar entre 0 y 100");

            Entrevista e = new Entrevista(candidatoID, vacanteID, etapaID, puntuacion);
            _dao.Insertar(e);
        }

        // metodo para obtener entrevistas
        public List<Entrevista> ObtenerEntrevistas()
        {
            return _dao.ObtenerTodos();
        }

        // metodo para eliminar entrevista
        public void EliminarEntrevista(int id)
        {
            _dao.Eliminar(id);
        }

        // metodo para actualizar entrevista
        public void ActualizarEntrevista(Entrevista e)
        {
            _dao.Actualizar(e);
        }

        // metodo como funcion para filtrar entrevistas por puntuacion con lambda
        public List<Entrevista> FiltrarPorPuntuacion(decimal minima)
        {
            List<Entrevista> todas = _dao.ObtenerTodos();
            Func<Entrevista, bool> filtro = e => e.Puntuacion >= minima;
            return todas.Where(filtro).ToList();
        }
    }
}