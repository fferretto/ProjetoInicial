using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Helper
{
    [ViewComponent(Name = "ListMenu")]
    public class ListMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("~/Views/Shared/Master.cshtml");
        }

    }
}
