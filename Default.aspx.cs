using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal {
    public partial class _Default : Page {
        //static List<Album> albumes = new List<Album>();
        static List<Cancion> canciones = new List<Cancion>();
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ButtonAgregarCancion_Click(object sender, EventArgs e) {
            Archivo archivo = new Archivo();
            List<Album> albumes = archivo.Leer(); 

            if (albumes != null) {
                if ((TextBoxTituloAlbum.Text != "") && (TextBoxArtistaAlbum.Text != "") && (TextBoxFechaPublicacion.Text != "") && (TextBoxNombreCancion.Text != "") && (TextBoxTiempoDuracion.Text != "")) {
                    Cancion cancionNueva = new Cancion();
                    cancionNueva.NombreCancion = TextBoxNombreCancion.Text;
                    cancionNueva.TiempoDuracion = TextBoxTiempoDuracion.Text;

                    canciones.Add(cancionNueva);
                }
            }
        }

        protected void ButtonGuardarAlbum_Click(object sender, EventArgs e) {
            Archivo archivo = new Archivo();
            List<Album> albumes = archivo.Leer();
            Album newAlbum = new Album();

            newAlbum.TituloAlbum = TextBoxTituloAlbum.Text;
            newAlbum.ArtistaAlbum = TextBoxArtistaAlbum.Text;
            newAlbum.Canciones = canciones;
            newAlbum.FechaPublicacion = TextBoxFechaPublicacion.Text;

            albumes.Add(newAlbum);

            archivo.Grabar(albumes);
        }
    }
}