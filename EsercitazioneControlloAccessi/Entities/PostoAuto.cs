namespace EsercitazioneControlloAccessi.Entities
{
    public class PostoAuto
    {
        public int Id { get; set; }
        public List<Visita>? Visite { get; set; }
    }
}
