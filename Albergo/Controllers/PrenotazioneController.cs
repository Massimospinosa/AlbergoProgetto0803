using Microsoft.AspNetCore.Mvc;
using Albergo.Models;
using System.Linq;

namespace Albergo.Controllers
{
    public class PrenotazioneController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrenotazioneController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prenotazione/Cerca
        public IActionResult Cerca(string codiceFiscale)
        {
            var prenotazioni = _context.Prenotazioni
                .Where(p => p.ClienteCodiceFiscale == codiceFiscale)
                .ToList();



