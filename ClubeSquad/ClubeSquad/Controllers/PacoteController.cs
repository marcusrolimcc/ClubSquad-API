using ClubeSquad.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubeSquad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacoteController : ControllerBase
    {
        public Contexto Contexto;

        public PacoteController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<PacoteController>
        [HttpGet]
        [Route("listar")]
        public List<Pacote> Listar()
        {
            return Contexto.Pacotes.ToList();
        }

        // POST api/<PacoteController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Pacote>> Incluir(Pacote pacote)
        {
            pacote.Id = 0;
            Contexto.Pacotes.Add(pacote);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = pacote.Id });
        }

        // PUT api/<PacoteController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Pacote>> Alterar(Pacote pacote)
        {
            Contexto.Update(pacote);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = pacote.Id });
        }
    }
}
