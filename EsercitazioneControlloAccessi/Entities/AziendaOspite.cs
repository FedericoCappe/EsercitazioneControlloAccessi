namespace EsercitazioneControlloAccessi.Entities
{
    public class AziendaOspite
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public List<Ospite>? Ospiti { get; set; }
    }
}
