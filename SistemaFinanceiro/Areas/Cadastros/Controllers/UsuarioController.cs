using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace SistemaFinanceiro.Areas.Cadastros.Controllers
{
    [Area("Cadastros")]
    public class UsuarioController : Controller
    {
        private readonly IUsarioApp _user;
        public UsuarioController(IUsarioApp user)
        {
            _user = user;
        }
        public IActionResult Index(int? id)
        {
            var dadosUsuario = _user.BuscaUsuarioByID(Convert.ToInt32(id));

            return View(dadosUsuario);
        }
        public IActionResult ConsultaUsuarios()
        {
            var ListaUsuario = _user.BuscaTodosUsuarios();
            return PartialView(ListaUsuario);
        }
        [HttpPost]
        public ActionResult Salvar(DadosUsuarioVM model)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    var result = _user.SalvarUsuario(model);
                    if (result.FirstOrDefault().Key)
                    {
                        TempData["Avis.Sucesso"] = result.FirstOrDefault().Value;
                        return RedirectToAction("Index", new { id = model.codigoUsuario });
                    }
                    else
                    {
                        ModelState.AddModelError("Error", result.FirstOrDefault().Value.ToString());
                        TempData["Avis.Aviso"] = result.FirstOrDefault().Value.ToString();
                        return View("Index", model);
                    }

                }

                return View("Index", model);
            }
            catch (Exception ex)
            {
                var msgErro = ex.Message;
                TempData["Avis.Erro"] = "Ocorreu uma falha ao salvar o usuário. Favor contactar o suporte.";
                return View("Index", model);
            }
        }
        [HttpPost]
        public ActionResult Desativar(DadosUsuarioVM model)
        {
            try
            {
                var result = _user.DesativaUsuario(model.codigoUsuario);

                TempData["Avis.Sucesso"] = result.FirstOrDefault().Value;
                return RedirectToAction("Index", new { id = "" });

            }
            catch (Exception ex)
            {
                TempData["Avis.Erro"] = ex.Message;
                return View("Index", model.codigoUsuario);
            }
        }
    }
}