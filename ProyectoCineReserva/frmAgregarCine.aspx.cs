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
    public partial class frmAgregarCine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            var cine = new Cine()
            {
                Nombre=this.txtNombre.Text,
                Provincia=this.txtProvincia.Text,
                Direccion=this.txtDireccion.Text,
                Aforo=int.Parse(this.txtAforo.Text),
                nroSalas=int.Parse(this.txtNroSalas.Text)
            };
            var DAO = new CineDAO();
            if (cine != null)
            {
                DAO.Crear(cine);
                Response.Redirect("frmListarCine.aspx");
            }



        }
    }
}