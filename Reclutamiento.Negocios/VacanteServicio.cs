using Reclutamiento.Datos;

namespace Reclutamiento.Negocio
{
    // capa de negocio - logica y validaciones de vacantes
    public class VacanteServicio
    {
        private VacanteDAO _dao = new VacanteDAO();

        // metodo normal - registra una vacante con validacion
        public void RegistrarVacante(string titulo, string descripcion, string departamento)
        {
            if (string.IsNullOrEmpty(titulo))
                throw new ArgumentException("El titulo es requerido");

            Vacante v = new Vacante(titulo, descripcion, departamento);
            _dao.Insertar(v);
        }

        // metodo normal- obtiene todas las vacantes de la BD
        public List<Vacante> ObtenerVacantes()
        {
            return _dao.ObtenerTodos();
        }

        // metodo normal- elimina una vacante por su ID
        public void EliminarVacante(int id)
        {
            _dao.Eliminar(id);
        }

        // metodo normal- actualiza los datos de una vacante
        public void ActualizarVacante(Vacante v)
        {
            _dao.Actualizar(v);
        }

        // metodo como funcion - con lambda para filtrar vacantes por estado
        // demuestra el uso de delegados y expresiones lambda
        public List<Vacante> FiltrarPorEstado(string estado)
        {
            List<Vacante> todas = _dao.ObtenerTodos();
            // lambda: retorna true si el estado de la vacante coincide con el buscado
            Func<Vacante, bool> filtro = v => v.Estado == estado;
            return todas.Where(filtro).ToList();
        }
    }
}