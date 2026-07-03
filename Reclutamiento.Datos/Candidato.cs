namespace Reclutamiento.Datos
{
    //clase abstracta
    public abstract class Persona
    {
        //encapsulacion
        private string _nombre;
        private string _cedula;

        //encapsulacion validando set
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
        //encapsulacion validando set
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

        //constructor default
        public Persona()
        {
            this.Nombre = "Sin nombre";
            this.Cedula = "000-0000000-0";
        }

        //constructor parametrizado
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

        //constructor parametrizado
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

        //override y polimorfismo
        public override double CalcularPuntuacion()
        {
            //operador ternario-- suma 10 si es interno, suma 0 si no es
            return EsInterno ? 10.0 : 0.0;
        }
    }

    //herencia reclutador:persona
    public class Reclutador : Persona
    {
        public int ReclutadorID { get; set; }
        public string Departamento { get; set; }
        public string Email { get; set; }

        //constructor parametrizado
        public Reclutador(string nombre, string cedula, string departamento, string email)
            : base(nombre, cedula)
        {
            this.Departamento = departamento;
            this.Email = email;
        }

        //constructor default
        public Reclutador() : base()
        {
            this.Departamento = "RRHH";
            this.Email = "sin@email.com";
        }

        //override y polimorfismo - comportamiento diferente al de candidato
        public override double CalcularPuntuacion()
        {
            //reclutador siempre tiene puntuacion maxima por ser personal interno
            return 100.0;
        }
    }
}