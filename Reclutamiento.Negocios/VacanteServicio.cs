using Reclutamiento.Datos;

namespace Reclutamiento.Negocio
{
    public class VacanteServicio
    {
        private VacanteDAO _dao = new VacanteDAO();

        // metodo para registrar vacante
        public void RegistrarVacante(string titulo, string descripcion, string departamento)
        {
            if (string.IsNullOrEmpty(titulo))
                throw new ArgumentException("El titulo es requerido");

            Vacante v = new Vacante(titulo, descripcion, departamento);
            _dao.Insertar(v);
        }

        // metodo para obtener vacantes
        public List<Vacante> ObtenerVacantes()
        {
            return _dao.ObtenerTodos();
        }

        // metodo para eliminar vacante
        public void EliminarVacante(int id)
        {
            _dao.Eliminar(id);
        }

        // metodo para actualizar vacante
        public void ActualizarVacante(Vacante v)
        {
            _dao.Actualizar(v);
        }

        // metodo como funcion - filtrar vacantes por estado con lambda
        public List<Vacante> FiltrarPorEstado(string estado)
        {
            List<Vacante> todas = _dao.ObtenerTodos();
            Func<Vacante, bool> filtro = v => v.Estado == estado;
            return todas.Where(filtro).ToList();
        }
    }
}