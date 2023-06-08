<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PracticaFinal.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 align="center">EDICION ALBÚM</h2>
    <h3>Ingrese nombre del album a editar:
        <asp:TextBox ID="TextBoxBuscarAlbum" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="BUSCAR" />
&nbsp;<asp:Label ID="LabelEstado" runat="server" Text="[ESTADO]"></asp:Label>
    </h3>
        <p class="lead">Titulo de albúm:
            <asp:TextBox ID="TextBoxTituloAlbum" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p class="lead">Artista del albúm:
            <asp:TextBox ID="TextBoxArtistaAlbum" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p class="lead">Fecha publicación:
            <asp:TextBox ID="TextBoxFechaPublicacion" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonEditar" runat="server" Enabled="False" Height="42px" OnClick="ButtonEditar_Click" Text="EDITAR" Width="99px" />
            &nbsp;</p>
</asp:Content>
