using System;
using System.Collections.Generic;
using System.Text;

namespace Reclutamiento.Datos
{
    // interfaz para cualquier clase que pueda tener un archivo adjunto (CV)
    public interface IArchivoAdjunto
    {
        void AdjuntarCV(string rutaArchivo);
        string ObtenerRutaCV();
    }
}
