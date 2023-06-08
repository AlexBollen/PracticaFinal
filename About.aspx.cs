using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal {
    public partial class About : Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e) {
            Archivo archivo = new Archivo();
            List<Album> albumes = archivo.Leer();
            Album albumExiste = albumes.Find(a => a.TituloAlbum == TextBoxBuscarAlbum.Text);

            if (albumExiste != null) {
                Response.Write("<script>alert('Albúm Encontrado.')</script>");
                LabelEstado.Text = albumExiste.TituloAlbum.ToString();
                ButtonEditar.Enabled = true;
                TextBoxArtistaAlbum.Enabled = true;
                TextBoxTituloAlbum.Enabled = true;
                TextBoxFechaPublicacion.Enabled = true;

                TextBoxTituloAlbum.Text = albumExiste.TituloAlbum;
                TextBoxArtistaAlbum.Text = albumExiste.ArtistaAlbum;
                TextBoxFechaPublicacion.Text = albumExiste.FechaPublicacion;
            } else {
                Response.Write("<script>alert('Albúm NO Encontrado.')</script>");
            }
        }

        protected void ButtonEditar_Click(object sender, EventArgs e) {
            Archivo archivo = new Archivo();
            List<Album> albumes = archivo.Leer();
            Album album = albumes.Find(u => u.TituloAlbum == LabelEstado.Text);
            album.TituloAlbum = TextBoxTituloAlbum.Text;
            album.ArtistaAlbum = TextBoxArtistaAlbum.Text;
            album.FechaPublicacion = TextBoxFechaPublicacion.Text;

            Response.Write("<script>alert('Datos de albúm actualizados.')</script>");
            archivo.Grabar(albumes);

            TextBoxBuscarAlbum.Text = "";
            ButtonBuscar.Enabled = false;
            TextBoxArtistaAlbum.Enabled = false;
            TextBoxTituloAlbum.Enabled = false;
            TextBoxFechaPublicacion.Enabled = false;
            LabelEstado.Text = "[ESTADO]";
        }
    }
}