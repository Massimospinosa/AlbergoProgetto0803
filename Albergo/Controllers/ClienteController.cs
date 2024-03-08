using Microsoft.AspNetCore.Mvc;

namespace Albergo.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult RicercaPrenotazioni(string codiceFiscale)
        {
            return View();
        }
    }

}
