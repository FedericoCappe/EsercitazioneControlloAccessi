namespace EsercitazioneControlloAccessi.Entities
{
    public class Azienda
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public List<Dipendente>? Dipendenti { get; set; }
    }
}
