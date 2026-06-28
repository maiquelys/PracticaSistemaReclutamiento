namespace Reclutamiento.Datos
{
    //clase abstracta
    public abstract class Persona
    {
        //encapsulacion
        private string _nombre;
        private string _cedula;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Nombre no puede estar vacio");
                _nombre = value;
            }
        }

        public string Cedula
        {
            get { return _cedula; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Cedula no puede estar vacia");
                _cedula = value;
            }
        }

        //constructor

        public Persona()
        {
            this.Nombre = "Sin nombre";
            this.Cedula = "000-0000000-0";
        }
        //constructor
        public Persona(string nombre, string cedula)
        {
            this.Nombre = nombre;
            this.Cedula = cedula;
        }
        //metodo abstracto
        public abstract double CalcularPuntuacion();
    }

    //herencia candidato:persona
    public class Candidato : Persona
    {
        public int CandidatoID { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool EsInterno { get; set; }

        public Candidato(string cedula, string nombre, string email, string telefono, bool esInterno)
            : base(nombre, cedula)
        {
            this.Email = email;
            this.Telefono = telefono;
            this.EsInterno = esInterno;
        }

        //constructor cedula
        public Candidato(string cedula) : base()
        {
            this.Cedula = cedula;
        }

        //destructor
        ~Candidato()
        {
            //libera candidato de la memoria al finalizar
            Console.WriteLine($"Candidato {Nombre} eliminadodo de memoria");
        }
        //override
        public override double CalcularPuntuacion()
        {
            return EsInterno ? 10.0 : 0.0;
        }
    }
}
