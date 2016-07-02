using ProyectoCineReserva.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoCineReserva.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var dao =new PeliculaDAO();
            var listado = dao.ListarTodos();

            return View(listado);
        }

        public ActionResult DetallePelicula(int id)
        {
            var dao = new PeliculaDAO();
            var pelicula = dao.Obtener(id);
            return View();
        }
        
    }
}