namespace Reclutamiento.Datos
{
    public class DecisionFinal
    {
        public int DecisionID { get; set; }
        public int CandidatoID { get; set; }
        public int VacanteID { get; set; }
        public string Decision { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }

        //constructor
        public DecisionFinal(int candidatoID, int vacanteID, string decision, string comentario)
        {
            this.CandidatoID = candidatoID;
            this.VacanteID = vacanteID;
            this.Decision = decision;
            this.Fecha = DateTime.Now;
            this.Comentario = comentario;
        }
        public DecisionFinal()
        {
            this.Decision = "Pendiente";
            this.Fecha = DateTime.Now;
            this.Comentario = "";
        }
        //destructor
        ~DecisionFinal()
        {
            Console.WriteLine($"Decision {Decision} procesada y eliminada de memoria");
        }
    }
}