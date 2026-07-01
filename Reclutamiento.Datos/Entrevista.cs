namespace Reclutamiento.Datos
{
    public class Entrevista
    {
        public int EntrevistaID { get; set; }
        public int CandidatoID { get; set; }
        public int VacanteID { get; set; }
        public int EtapaID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Puntuacion { get; set; }

        //constructor
        public Entrevista(int candidatoID, int vacanteID, int etapaID, decimal puntuacion)
        {
            this.CandidatoID = candidatoID;
            this.VacanteID = vacanteID;
            this.EtapaID = etapaID;
            this.Fecha = DateTime.Now;
            this.Puntuacion = puntuacion;
        }
        public Entrevista()
        {
            this.Fecha = DateTime.Now;
            this.Puntuacion = 0;
        }
    }
}