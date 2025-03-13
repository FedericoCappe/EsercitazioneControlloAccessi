namespace EsercitazioneControlloAccessi.Entities
{
    public class Ospite
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Cognome { get; set; }
        public List<Visita>? Visite { get; set; }
    }
}
