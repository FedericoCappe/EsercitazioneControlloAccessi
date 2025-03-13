namespace EsercitazioneControlloAccessi.Entities
{
    public class Wifi
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Password { get; set; }
        public List<Visita>? Visite { get; set; }
    }
}
