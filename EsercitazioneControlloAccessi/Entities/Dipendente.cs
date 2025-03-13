using System.ComponentModel.DataAnnotations.Schema;

namespace EsercitazioneControlloAccessi.Entities
{
    public class Dipendente
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Cognome { get; set; }
        public int RuoloId { get; set; }
        [ForeignKey(nameof(RuoloId))]
        public Ruolo? Ruolo { get; set; }
        public List<Visita>? VisiteAccompagnate { get; set; }
        public List<Prenotazione>? VisitePrenotate { get; set; }
    }
}
