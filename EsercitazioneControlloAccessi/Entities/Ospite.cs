using System.ComponentModel.DataAnnotations.Schema;

namespace EsercitazioneControlloAccessi.Entities
{
    public class Ospite
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Cognome { get; set; }
        public int AziendaId { get; set; }
        [ForeignKey(nameof(AziendaId))]
        public AziendaOspite? AziendaOspite { get; set; }
        public List<Visita>? Visite { get; set; }
    }
}
