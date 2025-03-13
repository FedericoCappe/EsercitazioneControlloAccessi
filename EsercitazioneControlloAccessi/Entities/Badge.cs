namespace EsercitazioneControlloAccessi.Entities
{
    public class Badge
    {
        public int Id { get; set; }
        public required string Descrizione { get; set; }
        public List<Visita>? Visite { get; set; }
    }
}
