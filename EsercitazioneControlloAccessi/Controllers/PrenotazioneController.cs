using EsercitazioneControlloAccessi.DTO;
using EsercitazioneControlloAccessi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsercitazioneControlloAccessi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrenotazioneController : ControllerBase
    {
        private readonly ControlloAccessiDbContext _ctx;
        private readonly Mapper _mapper;

        public PrenotazioneController(ControlloAccessiDbContext ctx, Mapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult NuovaVisita([FromBody] Prenotazione prenotazione)
        {
            try
            {
                if (prenotazione == null)
                    return BadRequest();
                _ctx.Prenotazioni.Add(prenotazione);
                _ctx.SaveChanges();
                return Created();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
