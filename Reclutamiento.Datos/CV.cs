using System;

namespace Reclutamiento.Datos
{
    public class CV
    {
        public int CVID { get; set; }
        public int CandidatoID { get; set; }
        public string RutaArchivo { get; set; }
        public DateTime FechaSubida { get; set; }

        public CV() { }

        public CV(int candidatoID, string rutaArchivo)
        {
            this.CandidatoID = candidatoID;
            this.RutaArchivo = rutaArchivo;
            this.FechaSubida = DateTime.Now;
        }
    }
}