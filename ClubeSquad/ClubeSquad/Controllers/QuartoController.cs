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
    public class QuartoController : ControllerBase
    {
        public Contexto Contexto;

        public QuartoController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<QuartoController>
        [HttpGet]
        [Route("listar")]
        public List<Quarto> Listar()
        {
            return Contexto.Quartos.ToList();
        }

        // POST api/<QuartoController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Quarto>> Incluir(Quarto quarto)
        {
            quarto.Id = 0;
            Contexto.Quartos.Add(quarto);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = quarto.Id });
        }

        // PUT api/<QuartoController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Quarto>> Alterar(Quarto quarto)
        {
            Contexto.Update(quarto);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = quarto.Id });
        }
    }
}
