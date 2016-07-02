using ProyectoCineReserva.Models;
using ProyectoCineReserva.Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoCineReserva.Controllers
{
    public class PeliculaController : Controller
    {
        // GET: Pelicula
        public ActionResult Create() 
        {
            
            
            return View();
        }

        [HttpPost]

        public ActionResult Create(Pelicula pelicula, HttpPostedFileBase fimage)
        {
            var dao = new PeliculaDAO();
            if (fimage != null)
            {
                using (var reader = new BinaryReader(fimage.InputStream))
                {
                    byte[] data = reader.ReadBytes(fimage.ContentLength);
                    pelicula.Imagen = data;
                }
            }
            else
            {
                pelicula.Imagen = new byte[]{};
            }

            dao.Crear(pelicula);
            return View();
        }



    }

    
    
}