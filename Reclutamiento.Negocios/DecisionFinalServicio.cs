using Reclutamiento.Datos;

namespace Reclutamiento.Negocio
{
    public class DecisionFinalServicio
    {
        private DecisionFinalDAO _dao = new DecisionFinalDAO();

        // metodo para registrar decision
        public void RegistrarDecision(int candidatoID, int vacanteID, string decision, string comentario)
        {
            if (string.IsNullOrEmpty(decision))
                throw new ArgumentException("La decision es requerida");

            DecisionFinal d = new DecisionFinal(candidatoID, vacanteID, decision, comentario);
            _dao.Insertar(d);
        }

        // metodo para obtener decisiones
        public List<DecisionFinal> ObtenerDecisiones()
        {
            return _dao.ObtenerTodos();
        }

        // metodo para eliminar decision
        public void EliminarDecision(int id)
        {
            _dao.Eliminar(id);
        }

        // metodo como funcion - filtrar decisiones con lambda
        public List<DecisionFinal> FiltrarPorDecision(string decision)
        {
            List<DecisionFinal> todas = _dao.ObtenerTodos();
            Func<DecisionFinal, bool> filtro = d => d.Decision == decision;
            return todas.Where(filtro).ToList();
        }
    }
}