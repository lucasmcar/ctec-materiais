using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ctec_Materiais.Models;
using Ctec_Materiais.Models.ViewModels;
using Ctec_Materiais.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ctec_Materiais.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly UsuarioService _usuarioService;
        private readonly MaterialService _materialService;

        public UsuariosController(UsuarioService us, MaterialService ms)
        {
            _usuarioService = us;
            _materialService = ms;
        }

        public IActionResult Index()
        {
            var list = _usuarioService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var materiais = _materialService.FindAll();

            //vm = view model
            var vm = new UsuarioFormViewModel
            {
                Materiais = materiais
            };
            return View( vm );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usuario usuario)
        {
            _usuarioService.Insert(usuario);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _usuarioService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _usuarioService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}