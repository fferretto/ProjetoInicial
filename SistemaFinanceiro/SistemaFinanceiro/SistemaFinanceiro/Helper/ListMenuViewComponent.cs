using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Helper
{
    [ViewComponent(Name = "ListMenu")]
    public class ListMenuViewComponent : ViewComponent
    {
        public IViewComponentResult InvokeAsync()
        {
            return View("~/Views/Shared/Master.cshtml");
        }

    }
}
