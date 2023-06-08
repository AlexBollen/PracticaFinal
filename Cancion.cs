using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaFinal {
    public class Cancion {
        string nombreCancion;
        string tiempoDuracion;

        public string NombreCancion { get => nombreCancion; set => nombreCancion = value; }
        public string TiempoDuracion { get => tiempoDuracion; set => tiempoDuracion = value; }
    }
}