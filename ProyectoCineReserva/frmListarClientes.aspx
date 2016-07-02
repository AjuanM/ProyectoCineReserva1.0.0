<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="frmListarClientes.aspx.cs" Inherits="ProyectoCineReserva.frmListarClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView runat="server" ID="dvListado" 
        CssClass="table-bordered table table-hover" 
        AutoGenerateColumns="false" OnRowCommand="dvListado_RowCommand" >
        <Columns>
            <asp:HyperLinkField HeaderText="Codigo"
                DataTextField="idUsuario"
                DataNavigateUrlFields="idUsuario"
                DataNavigateUrlFormatString="frmEditarCliente.aspx?uid={0}"
                />
            <asp:BoundField HeaderText="Nombre" 
                DataField="Nombre"
                />
            <asp:BoundField HeaderText="Apellido" 
                DataField="Apellido"
                />
            <asp:BoundField HeaderText="Direccion"
                DataField="Direccion"
                />
            <asp:BoundField HeaderText="Telefono"
                dataField="Telefono" 
                />
            <asp:BoundField HeaderText="Dni"
                DataField="Dni"
                />
            <asp:BoundField HeaderText="User"
                DataField="userName"
                />
            <asp:BoundField HeaderText="Clave"
                DataField="Clave" 
                /> 
            <asp:BoundField  HeaderText="Tipo de Usuario"
                DataField="TipoUsuario"
                />
            <asp:TemplateField ShowHeader="false">
                <ItemTemplate>
                    <asp:ImageButton ID="btnEliminar" runat="server" ImageUrl="~/img/x.png"
                        OnClientClick="return confirm('Estas Seguro de Eliminar?')"
                        CommandName="Eliminar" CommandArgument='<%#Eval("idUsuario") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
</asp:Content>
