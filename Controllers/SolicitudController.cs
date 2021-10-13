using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using simulacro.Models;
using simulacro.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace simulacro.Controllers
{
    public class SolicitudController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SolicitudController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Registrar(){
            var categorias = _context.DataCategorias.ToList();
            List<SelectListItem> items = categorias.ConvertAll(d => {
                return new SelectListItem(){
                    Text = d.nombre,
                    Value = d.Id.ToString(),
                    Selected = false
                };
            }); 
           ViewBag.items = items;
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(SolicitudCompra solicitudCompra){
            if(ModelState.IsValid){
                _context.Add(solicitudCompra);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }
            return View(solicitudCompra);
        }

        public IActionResult Listar(){
            var solicitudes = _context.DataContactos.ToList();
            return View(solicitudes);
        }

    }
}