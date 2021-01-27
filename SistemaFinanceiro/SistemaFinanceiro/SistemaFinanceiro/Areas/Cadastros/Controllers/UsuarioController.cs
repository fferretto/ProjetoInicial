using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaFinanceiro.Areas.Cadastros.Controllers
{
    [Area("Cadastros")]
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}