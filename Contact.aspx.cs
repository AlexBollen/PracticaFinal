using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaFinal {
    public partial class Contact : Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e) {
            Archivo archivo = new Archivo();
            List<Album> albumes = archivo.Leer();

            Album albumExiste = albumes.Find(a => a.TituloAlbum == TextBoxBuscarAlbum.Text);

            if (albumExiste != null) {
                Response.Write("<script> alert('Album encontrado') </script>");
                LabelEncontrado.Text = albumExiste.TituloAlbum.ToString();
                ButtonEliminar.Enabled = true;
            }
            else {
                Response.Write("<script> alert('Album NO encontrado') </script>");
            }
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e) {
            Archivo archivo = new Archivo();
            List<Album> albumes = archivo.Leer();
            Album albumExiste = albumes.Find(u => u.TituloAlbum == LabelEncontrado.Text);
            albumes.Remove(albumExiste);
            Response.Write("<script> alert('Album eliminado') </script>");
            archivo.Grabar(albumes);

            TextBoxBuscarAlbum.Text = "";
            ButtonEliminar.Enabled = false;
            LabelEncontrado.Text = "[ESTADO]";
        }
    }
}