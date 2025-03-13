using EsercitazioneControlloAccessi.Entities;
using Microsoft.AspNetCore.Identity;




namespace EsercitazioneControlloAccessi.DTO
{
    public class Mapper
    {


        public DipendenteDTO MapEntityToDTO (Dipendente D)
        {
            return new DipendenteDTO
            {
                Nome=D.Nome,
                Cognome = D.Cognome,
                Id = D.Id,  

            };
        }
        public Dipendente MapDTOToEntity(DipendenteDTO D)
        {
            return new Dipendente
            {
                Nome = D.Nome,
                Cognome = D.Cognome,
                Id = D.Id,
                Password = D.Password ?? "default",
                RuoloId = D.RuoloId,
            };
        }
    }
}
