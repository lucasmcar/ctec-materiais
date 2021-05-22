using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ctec_Materiais.Models;
using Ctec_Materiais.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ctec_Materiais.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly UsuarioService _usuarioService;

        public UsuariosController(UsuarioService us)
        {
            _usuarioService = us;
        }

        public IActionResult Index()
        {
            var list = _usuarioService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usuario usuario)
        {
            _usuarioService.Insert(usuario);
            return RedirectToAction(nameof(Index));
        }
    }
}