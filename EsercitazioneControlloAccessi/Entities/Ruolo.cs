namespace EsercitazioneControlloAccessi.Entities
{
    public class Ruolo
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public List<Dipendente>? Dipendenti { get; set; }
    }
}
