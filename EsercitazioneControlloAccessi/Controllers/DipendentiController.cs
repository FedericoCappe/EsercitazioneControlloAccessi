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

        public IActionResult PostDipendente(DipendenteDTO)
















    }
}
