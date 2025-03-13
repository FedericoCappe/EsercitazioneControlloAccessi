using System.ComponentModel.DataAnnotations.Schema;

namespace EsercitazioneControlloAccessi.Entities
{
    public class Visita
    {
        public int Id { get; set; }
        public required string Descrizione { get; set; }
        public DateTime Date { get; set; }
        public int AccompagnatoreId { get; set; }
        [ForeignKey(nameof(AccompagnatoreId))]
        public Dipendente? Accompagnatore { get; set; }
        public int WifiId { get; set; }
        [ForeignKey(nameof(WifiId))]
        public Wifi? Wifi { get; set; }
        public int BadgeId { get; set; }
        [ForeignKey(nameof(BadgeId))]
        public Badge? Badge { get; set; }
        public int PrenotazioneId { get; set; }
        [ForeignKey(nameof(PrenotazioneId))]
        public Prenotazione? Prenotazione { get; set; }
    }
}
