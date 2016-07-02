using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoCineReserva.Models;
using ProyectoCineReserva.Persistencia;

namespace ProyectoCineReserva.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario

        UsuarioDAO usuDao = new UsuarioDAO();
        public ActionResult Index()
        {
            var listado = usuDao.ListarTodos();
            return View(listado);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            usuDao.Crear(usuario);
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int? id)
        {

            if(id.HasValue){
                var usu = usuDao.Obtener(id.Value);
                return View(usu);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public ActionResult Edit(Usuario usuario)
        {
            usuDao.Modificar(usuario);
            return RedirectToAction("Index");
        }

    }
}