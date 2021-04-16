using Microsoft.AspNetCore.Mvc;

namespace MiPrimeraaplicacionusandoBlazor.Server.Controllers
{
    public class BookTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
