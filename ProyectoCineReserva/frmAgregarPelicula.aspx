<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="frmAgregarPelicula.aspx.cs" Inherits="ProyectoCineReserva.frmAgregarPelicula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Titulo"></asp:Label>
    <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="TituloOriginal"></asp:Label>
    <asp:TextBox ID="txtTituloOriginal" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Duracion"></asp:Label>
    <asp:TextBox ID="txtDuracion" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Pais"></asp:Label>
    <asp:TextBox ID="txtPais" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Sinopsis"></asp:Label>
    <asp:TextBox ID="txtSinopsis" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Censura"></asp:Label>
    <asp:DropDownList ID="ddlCensura" runat="server">
        <asp:ListItem>May 14</asp:ListItem>
        <asp:ListItem>A. Todos</asp:ListItem>
        <asp:ListItem>May 18</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Lista Actores"></asp:Label>
    <asp:TextBox ID="txtListaActores" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Genero"></asp:Label>
    <asp:DropDownList ID="ddlGenero" runat="server">
        <asp:ListItem>Terror</asp:ListItem>
        <asp:ListItem>Accion</asp:ListItem>
        <asp:ListItem>Comedia</asp:ListItem>
        <asp:ListItem>Triller</asp:ListItem>
        <asp:ListItem>CienciaFiccion</asp:ListItem>
        <asp:ListItem>Romantica</asp:ListItem>
        <asp:ListItem>Fantasia</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label9" runat="server" Text="Estado"></asp:Label>
    <asp:DropDownList ID="ddlEstado" runat="server">
        <asp:ListItem>En Caterlera</asp:ListItem>
        <asp:ListItem>Suspendida</asp:ListItem>
        <asp:ListItem>Proximamente</asp:ListItem>
        <asp:ListItem>Fin</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label10" runat="server" Text="Idioma"></asp:Label>
    <asp:TextBox ID="txtIdioma" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label11" runat="server" Text="Subtitulos"></asp:Label>
    <asp:DropDownList ID="ddlSubtitulos" runat="server">
        <asp:ListItem>no</asp:ListItem>
        <asp:ListItem>si</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label12" runat="server" Text="Imagen"></asp:Label>
    <asp:FileUpload ID="fuImagen" runat="server" />
    <br />
</asp:Content>
