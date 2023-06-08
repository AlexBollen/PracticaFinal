<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PracticaFinal.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 align="center"><%: Title %>ELIMINCACION</h2>
    <h3>Ingrese el nombre del album a eliminar:
        <asp:TextBox ID="TextBoxBuscarAlbum" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar" />
    </h3>
    <p>
        <asp:Label ID="LabelEncontrado" runat="server" Text="[ESTADO]"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonEliminar" runat="server" Enabled="False" Height="40px" OnClick="ButtonEliminar_Click" Text="ELIMINAR" Width="105px" />
    </p>
</asp:Content>
