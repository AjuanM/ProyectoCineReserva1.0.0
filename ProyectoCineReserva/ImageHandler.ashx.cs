using ProyectoCineReserva.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCineReserva
{
    public class ImageHandler:IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var request = context.Request;
            if (!string.IsNullOrEmpty(request.QueryString["idPelicula"]))
            {
                int id = int.Parse(request.QueryString["idPelicula"].ToString());
                var pdao = new PeliculaDAO();
                var p = pdao.Obtener(id);
                if (p != null)
                {
                    if (p.Imagen != null && p.Imagen.Length > 0)
                    {
                        context.Response.ContentType = "image/jpeg";
                        context.Response.BinaryWrite(p.Imagen);
                    }
                }
            }
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


    }
}