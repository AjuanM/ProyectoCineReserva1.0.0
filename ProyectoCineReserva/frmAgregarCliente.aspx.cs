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
    public partial class frmAgregarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            var cliente=new Usuario(){
                Nombre=this.txtNombre.Text,
                Apellido=this.txtApellido.Text,
                Direccion=this.txtDireccion.Text,
                Telefono=this.txtTelefono.Text,
                Dni=this.txtDni.Text,
                userName=this.txtuserName.Text,
                Clave=this.txtClave.Text,
                TipoUsuario=this.txtTipoUsuario.Text
        };
            var UDAO = new UsuarioDAO();
            if (cliente != null) {
                UDAO.Crear(cliente);
            }

        }
    }
}