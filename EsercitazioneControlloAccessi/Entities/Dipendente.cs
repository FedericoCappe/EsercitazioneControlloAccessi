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
        public List<Visita>? Visite { get; set; }
        public int AziendaId { get; set; }
        [ForeignKey(nameof(AziendaId))]
        public Azienda? Azienda { get; set; }
    }
}
