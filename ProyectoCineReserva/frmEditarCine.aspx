<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="frmEditarCine.aspx.cs" Inherits="ProyectoCineReserva.frmEditarCine" %>
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
    <asp:Label ID="Label2" CssClass="col-lg-2 control-label" runat="server">Provincia</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtProvincia" CssClass="form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Label ID="Label3" CssClass="col-lg-2 control-label" runat="server">Direccion</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtDireccion"  CssClass="form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Label ID="Label4" CssClass="col-lg-2 control-label" runat="server">Aforo</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtAforo"  CssClass="form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Label ID="Label5" runat="server" CssClass="col-lg-2 control-label">nroSalas</asp:Label>
    <div class="">
    <asp:TextBox runat="server" ID="txtNroSalas"  CssClass=" form-control"></asp:TextBox>
    </div>
</div>
<div class="form-group">
    <asp:Button id="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"

          />
</div>
        </div>


</asp:Content>
