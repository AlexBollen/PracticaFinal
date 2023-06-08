using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaFinal {
    public class Album {
        string tituloAlbum;
        string artistaAlbum;
        List<Cancion> canciones;
        string fechaPublicacion;

        public string TituloAlbum { get => tituloAlbum; set => tituloAlbum = value; }
        public string ArtistaAlbum { get => artistaAlbum; set => artistaAlbum = value; }
        public List<Cancion> Canciones { get => canciones; set => canciones = value; }
        public string FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }

        public Album() {
            canciones = new List<Cancion>();
        }

    }
}