using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoCineReserva.Persistencia;
using ProyectoCineReserva.Models;

namespace ProyectoCineReserva.Controllers
{
    public class SalaController : Controller
    {
        // GET: Sala
        CineDAO cineDao = new CineDAO();
        SalaDAO salaDao = new SalaDAO();
        public ActionResult Index()
        {

            var listado = salaDao.ListarTodos();
            return View(listado);
        }

        public ActionResult Create()
        {
            var listado = cineDao.ListarTodos();
            ViewBag.Id = new SelectList(listado, "idCine", "Nombre");
            return View();
        }

       [HttpPost]
        public ActionResult Create(Sala sala, int combo)
        {
           
            Cine cine = cineDao.Obtener(combo);
            sala.cine = cine;
            salaDao.Crear(sala);
            return RedirectToAction("Index");
        }

    }
}