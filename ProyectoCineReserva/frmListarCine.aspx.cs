using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoCineReserva.Persistencia;

namespace ProyectoCineReserva
{
    public partial class frmListarCine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarDatos();
            }
        }

        protected void CargarDatos()
        {
            var CDAO = new CineDAO();
            var listado = CDAO.ListarTodos();
            this.gvListado.DataSource = listado;
            this.gvListado.DataBind();
        }

        protected void dlListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvListado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var CDAO = new CineDAO();
            if (e.CommandName.Equals("Eliminar")) {
                int id = Convert.ToInt32(e.CommandArgument);
                CDAO.Eliminar(CDAO.Obtener(id));
                CargarDatos();
            }
        }

      
    }
}