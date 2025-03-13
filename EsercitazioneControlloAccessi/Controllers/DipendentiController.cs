using EsercitazioneControlloAccessi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsercitazioneControlloAccessi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DipendentiController : ControllerBase
    {

        private readonly ControlloAccessiDbContext _ctx;
        private readonly Mapper _mapper;

        public DipendentiController(ControlloAccessiDbContext ctx, Mapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        [HttpPost]  

        public IActionResult PostDipendente(DipendenteDTO DTO)
        {   
            var entity = _mapper.MapDTOToEntity(DTO);
            if(entity.Password.Equals("default"))
            {
                return BadRequest("Password non valida");
            }
            _ctx.Dipendenti.Add(entity);
            _ctx.SaveChanges();
            return Ok(DTO);
        }

        [HttpPost]














    }
}
