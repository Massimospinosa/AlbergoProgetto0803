namespace Albergo.Models
{
    public class ServizioAggiuntivo
    {
        public int ID { get; set; }
        public int PrenotazioneID { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
        public int Quantità { get; set; }
        public decimal Prezzo { get; set; }
    }
}
