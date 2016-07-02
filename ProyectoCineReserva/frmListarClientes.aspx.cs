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
    public partial class frmListarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarDatos();
            
            }
        }

        protected void cargarDatos()
        {
            var CDAO = new UsuarioDAO();
            this.dvListado.DataSource = CDAO.ListarTodos();
            this.dvListado.DataBind();
        }

        protected void dvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void dvListado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var CDAO = new UsuarioDAO();
            if (e.CommandName.Equals("Eliminar")) {
                int id = Convert.ToInt32(e.CommandArgument);
                CDAO.Eliminar(CDAO.Obtener(id));
                cargarDatos();
                               

            }

        }

       
    }
}