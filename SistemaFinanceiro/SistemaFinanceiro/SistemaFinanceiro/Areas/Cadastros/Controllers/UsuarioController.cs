using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaFinanceiro.Areas.Cadastros.Models;

namespace SistemaFinanceiro.Areas.Cadastros.Controllers
{
    [Area("Cadastros")]
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            FiltroCadUsuarioModel usu = new FiltroCadUsuarioModel();
            
            return View(usu);
        }
        public IActionResult ConsultaUsuarios()
        {
            List<FiltroCadUsuarioModel> usu = new List<FiltroCadUsuarioModel>();
            return PartialView(usu);
        }
    }
}