using Microsoft.AspNetCore.Mvc;

namespace Albergo.Controllers
{
    public class ServizioAggiuntivoController : Controller
    {
        public IActionResult AggiungiServizioAggiuntivo(int prenotazioneId)
        {
            return View();
        }
    }

}
