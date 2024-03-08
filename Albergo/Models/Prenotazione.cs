using System;
using System.Collections.Generic;

namespace Albergo.Models
{
    public class Prenotazione
    {
        public int ID { get; set; }
        public string ClienteCodiceFiscale { get; set; }
        public int NumeroCamera { get; set; }
        public DateTime DataPrenotazione { get; set; }
        public int NumeroProgressivoAnno { get; set; }
        public int Anno { get; set; }
        public DateTime PeriodoSoggiornoInizio { get; set; }
        public DateTime PeriodoSoggiornoFine { get; set; }
        public Decimal  Caparra { get; set; }
        public Decimal Tariffa { get; set; }
        public bool MezzaPensione { get; set; }
        public bool PensioneCompleta { get; set; }
        public bool PernottamentoPrimaColazione { get; set; }

        // Lista dei servizi aggiuntivi per questa prenotazione
        public List<ServizioAggiuntivo> ServiziAggiuntivi { get; set; }
    }
}
