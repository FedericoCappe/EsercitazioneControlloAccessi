using EsercitazioneControlloAccessi.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EsercitazioneControlloAccessi.DTO
{
    public class DipendenteDTO
    {



        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Cognome { get; set; }
        [MinLength(10)]
        public string? Password { get; set; }
        public int RuoloId { get; set; }
        [ForeignKey(nameof(RuoloId))]
        public Ruolo? Ruolo { get; set; }
        public List<VisitaDTO>? VisiteAccompagnate { get; set; }
        public List<PrenotazioneDTO>? VisitePrenotate { get; set; }






    }
}
