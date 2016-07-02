<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="frmAgregarCliente.aspx.cs" Inherits="ProyectoCineReserva.frmAgregarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container col-lg-6">

<div class="form-group">
    <asp:Label ID="Label1" runat="server" CssClass="col-lg-2 control-label">Nombre</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Label ID="Label2" CssClass="col-lg-2 control-label" runat="server">Apellido</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Label ID="Label3" CssClass="col-lg-2 control-label" runat="server">Direccion</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtDireccion"  CssClass="form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Label ID="Label4" CssClass="col-lg-2 control-label" runat="server">Telefono</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtTelefono"  CssClass="form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Label ID="Label5" runat="server" CssClass="col-lg-2 control-label">Dni</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtDni"  CssClass=" form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Label ID="Label6" runat="server" CssClass="col-lg-2 control-label">userName</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtuserName"  CssClass=" form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Label ID="Label7" runat="server" CssClass="col-lg-2 control-label">Clave</asp:Label>
    <div class="">
    <asp:TextBox  runat="server" TextMode="Password" ID="txtClave"  CssClass=" form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Label ID="Label8" runat="server" CssClass="col-lg-2 control-label">TipoUsuario</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtTipoUsuario"  CssClass=" form-control"></asp:TextBox>
    </div>
</div>

<div class="form-group">
    <asp:Button id="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click"
          />
</div>


</div>

</asp:Content>
