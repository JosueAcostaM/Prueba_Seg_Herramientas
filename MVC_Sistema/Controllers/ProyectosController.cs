using Sistema.API.Consumer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Modelos;

namespace MVC_Sistema.Controllers
{
    public class ProyectosController : Controller
    {
        // GET: ProyectosController
        public ActionResult Index()
        {
            var data= Crud<Proyectos>.GetAll();
            return View(data);
        }

        // GET: ProyectosController/Details/5
        public ActionResult Details(int id)
        {
            var data= Crud<Proyectos>.GetById(id);
            return View(data);  
        }

        private List<SelectListItem> GetTareas()
        {
            var tareas = Crud<Tareas>.GetAll();
            return tareas.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Nombre
            }).ToList();
        }

        private List<SelectListItem> GetUsuarios()
        {
            var usuarios = Crud<Usuario>.GetAll();
            return usuarios.Select(u=> new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.Nombre
            }   ).ToList();
        }

        // GET: ProyectosController/Create
        public ActionResult Create()
        {
            ViewBag.Usuarios = GetUsuarios();
            return View();
        }

        // POST: ProyectosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Proyectos data)
        {
            Console.WriteLine(data.Id);
            try
            {
                data.Estado = "Pendiente";
                Crud<Proyectos>.Create(data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }

        }

        // GET: ProyectosController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Proyectos>.GetById(id);
            ViewBag.Usuarios = GetUsuarios();
            return View(data);
        }

        // POST: ProyectosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Proyectos data)
        {
            try
            {
                Crud<Proyectos>.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }
        

        // GET: ProyectosController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Tareas>.GetById(id);
            return View(data);
        }

        // POST: ProyectosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Proyectos data)
        {
            try
            {
                Crud<Proyectos>.Delete(id);
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
