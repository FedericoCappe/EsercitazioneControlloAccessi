﻿using EsercitazioneControlloAccessi.DTO;
using EsercitazioneControlloAccessi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsercitazioneControlloAccessi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisiteController : ControllerBase
    {
        private readonly ControlloAccessiDbContext _ctx;
        private readonly Mapper _mapper;

        public VisiteController(ControlloAccessiDbContext ctx, Mapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult NuovaVisita([FromBody] Visita visita)
        {
            try
            {
                if(visita == null)
                    return BadRequest();
                if(string.IsNullOrWhiteSpace(visita.Descrizione))
                    return BadRequest();
                _ctx.Visite.Add(visita);
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
