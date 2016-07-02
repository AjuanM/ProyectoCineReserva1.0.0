using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoCineReserva.Persistencia;
using ProyectoCineReserva.Models;

namespace ProyectoCineReserva.Controllers
{
    public class CineController : Controller
    {
        // GET: Cine
        CineDAO cineDao = new CineDAO();
        public ActionResult Index()
        {
            var listado = cineDao.ListarTodos();
            return View(listado);
        }

        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cine cine)
        {
            cineDao.Crear(cine);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            
            if(id.HasValue){
                var cine = cineDao.Obtener(id.Value);
                return View(cine);
            }
            else
            {
                return RedirectToAction("Index");
            }            
            
        }

        [HttpPost]
        public ActionResult Edit(Cine cine)
        {
            
            cineDao.Modificar(cine);
            return RedirectToAction("Index");
        }
    }
}