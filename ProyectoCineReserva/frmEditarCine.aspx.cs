using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoCineReserva.Models;
using ProyectoCineReserva.Persistencia;

namespace ProyectoCineReserva
{
    public partial class frmEditarCine : System.Web.UI.Page
    {
        private static Cine cine = null;
        private static int id;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                int id;
                if (String.IsNullOrEmpty(Request.QueryString["uid"]))
                    Response.Redirect("frmListarCine.aspx");
                if (!int.TryParse(Request.QueryString["uid"], out id))
                    Response.Redirect("frmListarCine.aspx");
                var CDAO = new CineDAO();
               cine = CDAO.Obtener(id);
               if (cine != null) {
                   this.txtNombre.Text = cine.Nombre;
                   this.txtDireccion.Text = cine.Direccion;
                   this.txtProvincia.Text = cine.Provincia;
                   this.txtNroSalas.Text = cine.nroSalas+"";
                   this.txtAforo.Text = cine.Aforo+"";
               }

            }

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cine != null) {
                //cine.idCine = id; 
                cine.Nombre = this.txtNombre.Text;
                cine.Provincia = this.txtProvincia.Text;
                cine.Direccion = this.txtDireccion.Text;
                cine.Aforo = int.Parse(this.txtAforo.Text);
                cine.nroSalas = int.Parse(this.txtNroSalas.Text);

                var CDAO = new CineDAO();
                
                CDAO.Modificar(cine);
                Response.Redirect("frmListarCine.aspx");
            }


        }
    }
}