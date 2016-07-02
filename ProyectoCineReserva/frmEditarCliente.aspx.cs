using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoCineReserva.Persistencia;
using ProyectoCineReserva.Models;

namespace ProyectoCineReserva

{
    public partial class frmEditarCliente : System.Web.UI.Page
    {
        private static Usuario usu = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                int id;
                if (String.IsNullOrEmpty(Request.QueryString["uid"]))
                    Response.Redirect("frmListarClientes.aspx");
                if(!int.TryParse(Request.QueryString["uid"], out id))
                    Response.Redirect("frmListarClientes.aspx");
                var CDAO = new UsuarioDAO();
                usu = CDAO.Obtener(id);
                if (usu != null) {
                    this.txtNombre.Text = usu.Nombre;
                     this.txtApellido.Text=usu.Apellido;
                this.txtDireccion.Text=usu.Direccion;
                this.txtTelefono.Text=usu.Telefono;
                this.txtDni.Text=usu.Dni;
                this.txtuserName.Text=usu.userName;
                this.txtClave.Text=usu.Clave;
                    this.txtTipoUsuario.Text = usu.TipoUsuario;
                
                }


            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (usu != null) { 
                usu.Apellido = this.txtApellido.Text;
                usu.Direccion = this.txtDireccion.Text;
                usu.Telefono = this.txtTelefono.Text;
               usu.Dni = this.txtDni.Text;
               usu.userName = this.txtuserName.Text;
               usu.Clave = this.txtClave.Text;
               usu.TipoUsuario = this.txtTipoUsuario.Text;
               var CDAO = new UsuarioDAO();
               CDAO.Modificar(usu);
               Response.Redirect("frmListarClientes.aspx");
            }
            
            ;


        }
    }
}