using Sistema.API.Consumer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Modelos;

namespace MVC_Sistema.Controllers
{
    public class TareasController : Controller
    {
        // GET: TareasController
        public ActionResult Index()
        {
            var data= Crud<Tareas>.GetAll();
            return View(data);
        }

        // GET: TareasController/Details/5
        public ActionResult Details(int id)
        {
            var data= Crud<Tareas>.GetById(id);
            return View(data);  
        }


        private List<SelectListItem> GetUsuarios()
        {
            var usuarios = Crud<Usuario>.GetAll();
            return usuarios.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Nombre
            }).ToList();
        }

        private List<SelectListItem> GetProyectos()
        {
            var proyectos = Crud<Proyectos>.GetAll();
            return proyectos.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Nombre
            }).ToList();
        }

        // GET: TareasController/Create
        public ActionResult Create()
        {
            ViewBag.Usuarios= GetUsuarios();
            ViewBag.Proyecto= GetProyectos();
            return View();
        }

        // POST: TareasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tareas data)
        {
            try
            {
                data.Estado = "Pendiente";
                Crud<Tareas>.Create(data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: TareasController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Tareas>.GetById(id);
            ViewBag.Usuarios = GetUsuarios();
            ViewBag.Proyectos = GetProyectos();
            return View(data);
        }

        // POST: TareasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Tareas data)
        {
            try
            {
                Crud<Tareas>.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: TareasController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Tareas>.GetById(id);
            return View(data);
        }

        // POST: TareasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Tareas data)
        {
            try
            {
                Crud<Tareas>.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }
    }
}
