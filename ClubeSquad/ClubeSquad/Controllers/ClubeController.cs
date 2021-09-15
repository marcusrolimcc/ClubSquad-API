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
    public class ClubeController : ControllerBase
    {
        public Contexto Contexto;

        public ClubeController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<ClubeController>
        [HttpGet]
        [Route("listar")]
        public List<Clube> Listar()
        {
            return Contexto.Clubes.ToList();
        }

        // POST api/<ClubeController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Clube>> Incluir(Clube clube)
        {
            clube.Id = 0;
            Contexto.Clubes.Add(clube);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = clube.Id });
        }

        // PUT api/<ClubeController>/5
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult<Clube>> Alterar(Clube clube)
        {
            Contexto.Update(clube);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = clube.Id });
        }
    }
}
