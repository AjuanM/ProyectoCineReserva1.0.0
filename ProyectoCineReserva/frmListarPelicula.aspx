<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="frmListarPelicula.aspx.cs" Inherits="ProyectoCineReserva.frmListarPelicula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:DataList RepeatColumns="21" ID="dlListado" runat="server"
     OnSelectedIndexChanged="dlListado_SelectedIndexChanged">
            <ItemTemplate>
                <div class="thumbnail">
                    <div class="caption">
                         <h3><%#Eval("TituloOriginal") %></h3>
                         <p><%#Eval("TituloxPais") %></p>
                        <p><%#Eval("Duracion") %></p>
                        <p><%#Eval("Pais") %></p>
                        <p><%#Eval("Sinopsis") %></p>
                        <p><%#Eval("Censura") %></p>
                        <p><%#Eval("ListaActores") %></p>
                        <p><%#Eval("Genero") %></p>
                        <p><%#Eval("Estado") %></p>
                        <p><%#Eval("Idioma") %></p>
                        <p><%#Eval("Subtitulos") %></p>
                         <asp:Image ID="Image1" ImageUrl= '<%#"~/ImageHandler.ashx?id="+ Eval("idPelicula")%>' 
                              runat="server" CssClass="img-responsive" lenght="150" Width="150" />
                        <p>
                         <a href="#" class="btn btn-success">Detalles</a>
                         </p>
                    </div>

                </div>
            </ItemTemplate>

</asp:DataList>

</asp:Content>
