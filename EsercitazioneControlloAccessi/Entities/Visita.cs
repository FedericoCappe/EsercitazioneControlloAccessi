using System.ComponentModel.DataAnnotations.Schema;

namespace EsercitazioneControlloAccessi.Entities
{
    public class Visita
    {
        public int Id { get; set; }
        public required string Descrizione { get; set; }
        public DateTime Date { get; set; }
        public int DipendenteId { get; set; }
        [ForeignKey(nameof(DipendenteId))]
        public Dipendente? Dipendente { get; set; }
        public int? PostoAutoId { get; set; }
        [ForeignKey(nameof(PostoAutoId))]
        public PostoAuto? PostoAuto { get; set; }
        public int OspiteId { get; set; }
        [ForeignKey(nameof(OspiteId))]
        public Ospite? Ospite { get; set; }
        public int WifiId { get; set; }
        [ForeignKey(nameof(WifiId))]
        public Wifi? Wifi { get; set; }
    }
}
