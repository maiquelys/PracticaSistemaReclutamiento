namespace Reclutamiento.Datos
{
    public class Vacante
    {
        public int VacanteID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set;}
        public string Departamento { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Estado { get; set;}

        //constructor
        public Vacante(string titulo, string descripcion, string departamento)
        {
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Departamento = departamento;
            this.FechaPublicacion = DateTime.Now;
            this.Estado = "Activa";
        }

        //constructor
        public Vacante()
        {
            this.Titulo = "Sin titulo";
            this.Descripcion = "Sin descripcion";
            this.Departamento = "General";
            this.FechaPublicacion = DateTime.Now;
            this.Estado = "Activa";
        }
        //destructor
        ~Vacante()
        {
            Console.WriteLine($"Vacante {Titulo} cerrada y eliminada de memoria");
        }
    }
}