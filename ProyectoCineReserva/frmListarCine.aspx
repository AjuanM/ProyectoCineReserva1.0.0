<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="frmListarCine.aspx.cs" Inherits="ProyectoCineReserva.frmListarCine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView runat="server" ID="gvListado" 
        CssClass="table-bordered table table-hover" 
        AutoGenerateColumns="false" OnRowCommand="gvListado_RowCommand" >
        <Columns>
            <asp:HyperLinkField HeaderText="Codigo"
                DataTextField="idCine"
                DataNavigateUrlFields="idCine"
                DataNavigateUrlFormatString="frmEditarCine.aspx?uid={0}"
                />
            <asp:BoundField HeaderText="Nombre" 
                DataField="Nombre"
                />
            <asp:BoundField HeaderText="Provincia" 
                DataField="Provincia"
                />
            <asp:BoundField HeaderText="Direccion"
                DataField="Direccion"
                />
            <asp:BoundField HeaderText="Aforo"
                dataField="Aforo" 
                />
            <asp:BoundField HeaderText="nroSalas"
                DataField="nroSalas"
                />
            
            <asp:TemplateField ShowHeader="false">
                <ItemTemplate>
                    <asp:ImageButton ID="btnEliminar" runat="server" ImageUrl="~/img/x.png"
                        OnClientClick="return confirm('Estas Seguro de Eliminar?')"
                        CommandName="Eliminar" CommandArgument='<%#Eval("idCine") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
</asp:Content>
