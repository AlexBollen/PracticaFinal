<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PracticaFinal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 align="center">PRÁCTICA EXAMEN FINAL</h1>
        <p class="lead" align="center">Ingreso de productos a archivo JSON como práctica de lectura y escritura</p>
        <p class="lead">ALBÚM</p>
        <p class="lead">Titulo de albúm:
            <asp:TextBox ID="TextBoxTituloAlbum" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Artista del albúm:
            <asp:TextBox ID="TextBoxArtistaAlbum" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Fecha publicación:
            <asp:TextBox ID="TextBoxFechaPublicacion" runat="server"></asp:TextBox>
        </p>
        <p class="lead">CANCIONES</p>
        <p class="lead">Nombre canción:
            <asp:TextBox ID="TextBoxNombreCancion" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Tiempo de duración:
            <asp:TextBox ID="TextBoxTiempoDuracion" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonAgregarCancion" class="btn btn-warning btn-lg" runat="server" Text="Agregar canción" OnClick="ButtonAgregarCancion_Click" />
        </p>
        <p class="lead" >
            <asp:Button ID="ButtonGuardarAlbum" class="btn btn-primary btn-lg" runat="server" Text="Guardar albúm" OnClick="ButtonGuardarAlbum_Click" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
