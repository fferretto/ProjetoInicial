using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace SistemaFinanceiro.Areas.Cadastros.Controllers
{
    [Area("Cadastros")]
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            DadosUsuarioVM usu = new DadosUsuarioVM();
            
            return View(usu);
        }
        public IActionResult ConsultaUsuarios()
        {
            List<DadosUsuarioVM> usu = new List<DadosUsuarioVM>();
            return PartialView(usu);
        }
    }
}